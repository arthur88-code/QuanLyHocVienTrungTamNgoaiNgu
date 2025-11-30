using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using static BusinessLogic.GlobalSettings;

namespace BusinessLogic
{
    public static class NhanVien
    {
        /// Chọn một nhân viên
        public static NHANVIEN Select(string maNV)
        {
            return (from p in Database.NHANVIENs
                    where p.MaNV == maNV
                    select p).Single();
        }

        /// Lấy danh sách tất cả nhân viên
        public static object SelectAll()
        {
            return (from p in Database.NHANVIENs
                    select new
                    {
                        MaNV = p.MaNV,
                        TenNV = p.TenNV,
                        SdtNV = p.SdtNV,
                        EmailNV = p.EmailNV,
                        TenLoaiNV = p.LOAINV.TenLoaiNV
                    }).ToList();
        }

        /// Lấy danh sách nhân viên thỏa điều kiện
        public static object SelectAll(string maNV, string tenNV, string maLoaiHV)
        {
            return (from p in GlobalSettings.Database.NHANVIENs
                    where (maNV == null ? true : p.MaNV.Contains(maNV)) &&
                          (tenNV == null ? true : p.TenNV.Contains(tenNV)) &&
                          (maLoaiHV == null ? true : p.MaLoaiNV == maLoaiHV)
                    select new
                    {
                        MaNV = p.MaNV,
                        TenNV = p.TenNV,
                        SdtNV = p.SdtNV,
                        EmailNV = p.EmailNV,
                        TenLoaiNV = p.LOAINV.TenLoaiNV
                    }).ToList();
        }

        /// Thêm nhân viên
        public static void Insert(NHANVIEN nhanVien, TAIKHOAN taiKhoan)
        {
            Database.TAIKHOANs.InsertOnSubmit(taiKhoan);
            Database.NHANVIENs.InsertOnSubmit(nhanVien);
            Database.SubmitChanges();
        }

        /// Cập nhật thông tin nhân viên
        public static void Update(NHANVIEN nhanVien, TAIKHOAN taiKhoan = null)
        {
            var nhanVienCu = Select(nhanVien.MaNV);

            nhanVienCu.TenNV = nhanVien.TenNV;
            nhanVienCu.SdtNV = nhanVien.SdtNV;
            nhanVienCu.EmailNV = nhanVien.EmailNV;
            nhanVienCu.MaLoaiNV = nhanVien.MaLoaiNV;

            Database.SubmitChanges();
            if(taiKhoan!=null)
                TaiKhoan.Update(taiKhoan);         
        }

        /// Xóa một nhân viên
        public static void Delete(string maNV)
        {
            var temp = Select(maNV);
            string tenDangNhap = temp.TenDangNhap;

            Database.NHANVIENs.DeleteOnSubmit(temp);
            Database.SubmitChanges();

            TaiKhoan.Delete(tenDangNhap);
        }

        /// Tự động sinh mã nhân viên
        public static string AutoGenerateId()
        {
            string result = "NV";
            var temp = from p in GlobalSettings.Database.NHANVIENs
                       where p.MaNV.StartsWith(result)
                       select p.MaNV;
            int max = -1;

            foreach (var i in temp)
            {
                int j = int.Parse(i.Substring(2, 4));
                if (j > max) max = j;
            }

            return string.Format("{0}{1:D4}", result, max + 1);
        }
    }
}
