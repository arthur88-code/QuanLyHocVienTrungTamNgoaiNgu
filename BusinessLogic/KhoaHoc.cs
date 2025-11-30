using System.Linq;
using static BusinessLogic.GlobalSettings;
using DataAccess;

namespace BusinessLogic
{
    public static class KhoaHoc
    {
        
        /// Chọn tất cả khóa học
       

        public static object SelectAll()
        {
            return (from p in Database.KHOAHOCs
                    select p).ToList();
        }

        
        /// Chọn một khóa học
       
        public static KHOAHOC Select(string maKH)
        {
            return (from p in Database.KHOAHOCs
                    where p.MaKH == maKH
                    select p).Single();
        }

        
        /// Thêm một khóa học
        public static void Insert(KHOAHOC kh)
        {
            Database.KHOAHOCs.InsertOnSubmit(kh);
            Database.SubmitChanges();
        }

        
        /// Cập nhật thông tin khóa học
        public static void Update(KHOAHOC kh)
        {
            var khoaHocCu = Select(kh.MaKH);

            khoaHocCu.TenKH = kh.TenKH;
            khoaHocCu.HocPhi = kh.HocPhi;
            khoaHocCu.HeSoNghe = kh.HeSoNghe;
            khoaHocCu.HeSoNoi = kh.HeSoNoi;
            khoaHocCu.HeSoDoc = kh.HeSoDoc;
            khoaHocCu.HeSoViet = kh.HeSoViet;

            Database.SubmitChanges();
        }

        
        /// Xóa một khóa học
       
        public static void Delete(string maKH)
        {
            var kh = (from p in Database.KHOAHOCs
                      where p.MaKH == maKH
                      select p).Single();

            //xóa bảng đăng ký
            var dk = from p in Database.DANGKies
                     where p.MaKH == maKH
                     select p;
            Database.DANGKies.DeleteAllOnSubmit(dk);

            //xóa bảng lớp học
            var l = from p in Database.LOPHOCs
                    where p.MaKH == maKH
                    select p;
            foreach (var i in l)
            {
                LopHoc.Delete(i.MaLop);
            }

            //xóa khóa học
            Database.KHOAHOCs.DeleteOnSubmit(kh);
            Database.SubmitChanges();
        }

        
        /// Tự động sinh mã khóa học
       

        public static string AutoGenerateId()
        {
            string result = "KH";
            var temp = from p in GlobalSettings.Database.KHOAHOCs
                       select p.MaKH;
            int max = -1;

            foreach (var i in temp)
            {
                int j = int.Parse(i.Substring(2, 2));
                if (j > max) max = j;
            }

            return string.Format("{0}{1:D2}", result, max + 1);
        }
    }
}
