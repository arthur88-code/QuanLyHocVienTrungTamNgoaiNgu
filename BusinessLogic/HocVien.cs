using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using static BusinessLogic.GlobalSettings;

namespace BusinessLogic
{
    public static class HocVien
    {
        
        /// Chọn tất cả
        public static object SelectAll()
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    select p).ToList();
        }

        
        /// Chọn tất cả học viên theo loại
        public static object SelectAll(string maloai)
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    where p.MaLoaiHV == maloai
                    select p).ToList();
        }

        
        /// Chọn các học viên thỏa điều kiện
        public static object SelectAll(string maHV, string tenHV, string gioiTinh, DateTime? tuNgay, DateTime? denNgay, string maLoai)
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    where  (maLoai == null ? true : p.MaLoaiHV == maLoai) &&
                           (maHV == null ? true : p.MaHV.Contains(maHV)) &&
                           (tenHV == null ? true : p.TenHV.Contains(tenHV)) &&
                           (gioiTinh == null ? true : p.GioiTinhHV.Contains(gioiTinh)) &&
                           (tuNgay == null ? true : p.NgayTiepNhan >= tuNgay) &&
                           (denNgay == null ? true : p.NgayTiepNhan <= denNgay)
                    select p).ToList();
        }

        
        /// Chọn danh sách học viên chưa có lớp
        public static List<DANGKY> DanhSachChuaCoLop()
        {
            return (from p in Database.DANGKies
                    where !(from q in Database.BANGDIEMs
                            select q.MaPhieu).Contains(p.MaPhieu)
                    select p).ToList();
        }

        
        /// Chọn một học viên
        public static HOCVIEN Select(string maHV)
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    where p.MaHV == maHV
                    select p).Single();
        }

        
        /// Thêm một học viên
        public static void Insert(HOCVIEN hocVien, TAIKHOAN taiKhoan)
        {
            if (hocVien.MaLoaiHV == "LHV01")
                Database.TAIKHOANs.InsertOnSubmit(taiKhoan);
            Database.HOCVIENs.InsertOnSubmit(hocVien);
            Database.SubmitChanges();
        }

        
        /// Cập nhật một học viên
        public static void Update(HOCVIEN hocVien, TAIKHOAN taiKhoan = null)
        {
            var hocVienCu = Select(hocVien.MaHV);

            //không thay đổi loại
            hocVienCu.TenHV = hocVien.TenHV;
            hocVienCu.NgaySinh = hocVien.NgaySinh;
            hocVienCu.GioiTinhHV = hocVien.GioiTinhHV;
            hocVienCu.DiaChi = hocVien.DiaChi;
            hocVienCu.SdtHV = hocVien.SdtHV;
            hocVienCu.EmailHV = hocVien.EmailHV;
            hocVienCu.NgayTiepNhan = hocVien.NgayTiepNhan;

            if (hocVienCu.MaLoaiHV != hocVien.MaLoaiHV)
            {
                //đổi từ tiềm năng sang chính thức
                if (hocVien.MaLoaiHV == "LHV01")
                {
                    Database.TAIKHOANs.InsertOnSubmit(taiKhoan);
                    hocVienCu.MaLoaiHV = hocVien.MaLoaiHV;
                    hocVienCu.TenDangNhap = hocVien.TenDangNhap;
                }
                else
                {
                    hocVienCu.MaLoaiHV = hocVien.MaLoaiHV;
                    Database.TAIKHOANs.DeleteOnSubmit((from p in Database.TAIKHOANs where p.TenDangNhap == hocVienCu.TenDangNhap select p).Single());
                    hocVienCu.TenDangNhap = null;
                }
            }
            Database.SubmitChanges();
        }

        
        /// Xóa một học viên
        public static void Delete(string maHV)
        {
            var temp = Select(maHV);
            string maLoai = temp.MaLoaiHV;
            string tenDangNhap = temp.TenDangNhap;

            Database.HOCVIENs.DeleteOnSubmit(temp);
            Database.SubmitChanges();

            if (maLoai == "LHV01")
                TaiKhoan.Delete(tenDangNhap);
        }

        
        /// Tự động sinh mã học viên
        public static string AutoGenerateId()
        {
            string result = "HV" + DateTime.Now.ToString("yyMMdd");
            var temp = from p in GlobalSettings.Database.HOCVIENs
                       where p.MaHV.StartsWith(result)
                       select p.MaHV;
            int max = -1;

            foreach (var i in temp)
            {
                int j = int.Parse(i.Substring(8, 2));
                if (j > max) max = j;
            }

            return string.Format("{0}{1:D2}", result, max + 1);
        }

        
        /// Đếm tổng học viên
        public static int Count()
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    select p).Count();
        }

        
        /// Đếm học viên tiềm năng
        
        
        public static int CountTiemNang()
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    where p.MaLoaiHV == "LHV00"
                    select p).Count();
        }

        
        /// Đếm học viên chính thức
        
        public static int CountChinhThuc()
        {
            return (from p in GlobalSettings.Database.HOCVIENs
                    where p.MaLoaiHV == "LHV01"
                    select p).Count();
        }
    }
}
