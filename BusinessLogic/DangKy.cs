using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BusinessLogic.GlobalSettings;
using DataAccess;

namespace BusinessLogic
{
    public static class DangKy
    {
        /// Thêm một đăng ký
        public static void Insert(DANGKY dk)
        {
            Database.DANGKies.InsertOnSubmit(dk);
            Database.SubmitChanges();
        }

        /// Chọn một đăng ký
        public static DANGKY Select(string maHV, string maKH, string maPhieu)
        {
            return (from p in Database.DANGKies
                    where p.MaHV == maHV && p.MaKH == maKH && p.MaPhieu == maPhieu
                    select p).Single();
        }
        
        /// Tìm một đăng ký
        public static IQueryable<DANGKY> SelectAll(string maHV)
        {
            return (from p in Database.DANGKies
                    where p.MaHV == maHV
                    select p);
        }
    }
}
