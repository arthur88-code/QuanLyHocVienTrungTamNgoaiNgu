using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using static BusinessLogic.GlobalSettings;

namespace BusinessLogic
{
    public static class GiangDay
    {
        /// Chọn danh sách lớp của giảng viên
        public static object Select(string maGV)
        {
            return (from p in Database.GIANGDAYs
                    where p.MaGV == maGV
                    select new
                    {
                        MaLop = p.MaLop,
                        TenLop = p.LOPHOC.TenLop,
                        NgayBD = p.LOPHOC.NgayBD,
                        NgayKT = p.LOPHOC.NgayKT,
                        DangMo = p.LOPHOC.DangMo,
                        SiSo = p.LOPHOC.SiSo
                    }).ToList();
        }


        /// Xóa một quá trình giảng dạy của giảng viên
        public static void Delete(string maGV)
        {
            var temp = (from p in Database.GIANGDAYs
                        where p.MaGV == maGV
                        select p);

            Database.GIANGDAYs.DeleteAllOnSubmit(temp);
            Database.SubmitChanges();
        }

        /// Tìm các lớp thỏa điều kiện
        public static object SelectAll(string maGV, DateTime? tuNgay, DateTime? denNgay, string maKH)
        {
            return (from p in Database.GIANGDAYs
                    where p.MaGV == maGV &&
                          (tuNgay == null ? true : p.LOPHOC.NgayBD >= tuNgay) &&
                          (denNgay == null ? true : p.LOPHOC.NgayKT <= denNgay) &&
                          (maKH == null ? true : p.LOPHOC.MaKH == maKH)
                    select new
                    {
                        MaLop = p.MaLop,
                        TenLop = p.LOPHOC.TenLop
                    }).ToList();

        }
    }
}
