using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using static BusinessLogic.GlobalSettings;

namespace BusinessLogic
{
    public static class LopHoc
    {
        /// Lấy danh sách lớp
        public static object SelectAll()
        {
            return (from p in Database.LOPHOCs
                    select p).ToList();
        }

        /// Lấy danh sách lớp thỏa điều kiện
        public static object SelectAll(string maLop, string tenLop, string maKH, DateTime? tuNgay, DateTime? denNgay, bool? dangMo)
        {
            return (from p in Database.LOPHOCs
                    where (maLop == null ? true : p.MaLop.Contains(maLop)) &&
                          (tenLop == null ? true : p.TenLop.Contains(tenLop)) &&
                          (maKH == null ? true : p.MaKH == maKH) &&
                          (tuNgay == null ? true : p.NgayBD <= tuNgay) &&
                          (denNgay == null ? true : p.NgayKT >= denNgay) &&
                          (dangMo == null ? true : p.DangMo == dangMo)
                    select p).ToList();
        }


        /// Tự động sinh mã lớp
        public static string AutoGenerateId(DateTime ngayBD)
        {
            string result = "LH" + ngayBD.ToString("yyMMdd");
            var temp = from p in GlobalSettings.Database.HOCVIENs
                       where p.MaHV.StartsWith(result)
                       select p.MaHV;
            int max = -1;

            foreach (var i in temp)
            {
                int j = int.Parse(i.Substring(8, 1));
                if (j > max) max = j;
            }

            return string.Format("{0}{1:D1}", result, max + 1);
        }

        /// Chọn một lớp
        public static LOPHOC Select(string maLop)
        {
            return (from p in Database.LOPHOCs
                    where p.MaLop.Contains(maLop)
                    select p).Single();
        }

        /// Tìm một lớp
        public static object SelectAll(string maLop)
        {
            return (from p in Database.LOPHOCs
                    where p.MaLop.Contains(maLop)
                    select p);
        }

        /// Lấy danh sách lớp trống
        public static object DanhSachLopTrong(string maKhoa)
        {
            return (from p in Database.LOPHOCs
                    where p.MaKH == maKhoa &&
                            p.SiSo < (from q in Database.QUYDINHs
                                      where q.MaQD == "QD0000"
                                      select q.GiaTri).Single()
                    select new
                    {
                        MaLop = p.MaLop,
                        TenLop = p.TenLop
                    }).ToList();
        }

        /// Chèn lớp trống
        public static void Insert(LOPHOC lh)
        {
            Database.LOPHOCs.InsertOnSubmit(lh);
            Database.SubmitChanges();
        }

        /// Cập nhật thông tin lớp học
        public static void Update(LOPHOC lh)
        {
            var lopCu = Select(lh.MaLop);

            lopCu.TenLop = lh.TenLop;
            lopCu.NgayBD = lh.NgayBD;
            lopCu.NgayKT = lh.NgayKT;
            lopCu.SiSo = lh.SiSo;
            lopCu.MaKH = lh.MaKH;
            lopCu.DangMo = lh.DangMo;

            Database.SubmitChanges();
        }

        /// Xóa một lớp học
        public static void Delete(string maLop)
        {
            LOPHOC lh = Select(maLop);

            //xóa bảng điểm
            var bangDiem = (from p in Database.BANGDIEMs
                            where p.MaLop == maLop
                            select p);
            Database.BANGDIEMs.DeleteAllOnSubmit(bangDiem);

            //xóa giảng dạy
            var giangDay = (from p in Database.GIANGDAYs
                            where p.MaLop == maLop
                            select p);

            Database.GIANGDAYs.DeleteAllOnSubmit(giangDay);

            //xóa lớp
            Database.LOPHOCs.DeleteOnSubmit(lh);

            Database.SubmitChanges();
        }
    }
}
