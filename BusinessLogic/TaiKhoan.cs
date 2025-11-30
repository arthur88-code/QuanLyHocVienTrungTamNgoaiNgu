using System.Linq;
using DataAccess;
using static BusinessLogic.GlobalSettings;
using System.Collections.Generic;

namespace BusinessLogic
{
    public static class TaiKhoan
    {
        /// Chọn một tài khoản
        public static TAIKHOAN Select(string tenDangNhap)
        {
            return (from p in Database.TAIKHOANs
                    where p.TenDangNhap == tenDangNhap
                    select p).Single();
        }

        /// Lấy danh sách tài khoản
        public static List<TAIKHOAN> SelectAll(string tenDangNhap, UserType? loaiTK)
        {
            switch (loaiTK)
            {
                case null:
                    return (from p in Database.TAIKHOANs
                            where (tenDangNhap == null ? true : p.TenDangNhap.Contains(tenDangNhap))
                            select p).ToList();
                case UserType.NhanVien:
                    return (from p in Database.NHANVIENs
                            where (tenDangNhap == null ? true : p.TenDangNhap.Contains(tenDangNhap))
                            select p.TAIKHOAN).ToList();
                case UserType.HocVien:
                    return (from p in Database.HOCVIENs
                            where p.TenDangNhap != null &&
                                  (tenDangNhap == null ? true : p.TenDangNhap.Contains(tenDangNhap))
                            select p.TAIKHOAN).ToList();
                case UserType.GiangVien:
                    return (from p in Database.GIANGVIENs
                            where (tenDangNhap == null ? true : p.TenDangNhap.Contains(tenDangNhap))
                            select p.TAIKHOAN).ToList();
                default:
                    return null;
            }
        }

        /// Xóa tài khoản
        public static void Delete(string tenDangNhap)
        {
            var temp = (from p in Database.TAIKHOANs
                        where p.TenDangNhap == tenDangNhap
                        select p).Single();

            Database.TAIKHOANs.DeleteOnSubmit(temp);
            Database.SubmitChanges();
        }

        /// Đổi mật khẩu
        public static void Update(TAIKHOAN tk)
        {
            var temp = (from p in Database.TAIKHOANs
                        where p.TenDangNhap == tk.TenDangNhap
                        select p).Single();

            temp.MatKhau = tk.MatKhau;
            Database.SubmitChanges();
        }

        /// Trả về mã của tên đăng nhập
        public static string FullUserID(TAIKHOAN tk)
        {
            var a = (from p in Database.NHANVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (a != null)
                return a.MaNV;

            var b = (from p in Database.HOCVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (b != null)
                return b.MaHV;

            var c = (from p in Database.GIANGVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (c != null)
                return c.MaGV;

            return null;
        }

        /// Trả về kiểu người dùng của tên đăng nhập
        public static UserType? FullUserType(TAIKHOAN tk)
        {
            var a = (from p in Database.NHANVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (a != null)
                return UserType.NhanVien;

            var b = (from p in Database.HOCVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (b != null)
                return UserType.HocVien;

            var c = (from p in Database.GIANGVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (c != null)
                return UserType.GiangVien;
            return null;
        }

        /// Trả về tên người dùng của tên đăng nhập
        public static string FullUserName(TAIKHOAN tk)
        {
            var a = (from p in Database.NHANVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (a != null)
                return a.TenNV;

            var b = (from p in Database.HOCVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (b != null)
                return b.TenHV;

            var c = (from p in Database.GIANGVIENs
                     where p.TenDangNhap == tk.TenDangNhap
                     select p).SingleOrDefault();
            if (c != null)
                return c.TenGV;
            return null;
        }

        /// Xác định tên đăng nhập và mật khẩu có hợp lệ
        public static bool IsValid(string userName, string password)
        {
            try
            {
                return Select(userName).MatKhau == password;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
