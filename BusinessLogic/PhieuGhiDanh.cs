using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BusinessLogic.GlobalSettings;
using DataAccess;

namespace BusinessLogic
{
    public struct BaoCaoHocVienNo
    {
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public string GioiTinhHV { get; set; }
        public string TenKH { get; set; }
        public decimal? ConNo { get; set; }
    }
    public struct BaoCaoHocVienGhiDanh
    {
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public string GioiTinhHV { get; set; }
        public DateTime? NgayGhiDanh { get; set; }
        public string TenKH { get; set; }
    }
    public static class PhieuGhiDanh
    {
        /// Chọn tất cả phiếu ghi danh
        public static object SelectAll()
        {
            return (from p in Database.PHIEUGHIDANHs
                    select new
                    {
                        MaPhieu = p.MaPhieu,
                        MaHV = p.DANGKies.MaHV,
                        NgayGhiDanh = p.NgayGhiDanh,
                        DaDong = p.DaDong,
                        ConNo = p.ConNo
                    }).ToList();
        }
        
        /// Báo cáo học viên ghi danh theo tháng
        public static IQueryable<BaoCaoHocVienGhiDanh> BaoCaoHocVienGhiDanhTheoThang(int month, int year)
        {
            return from p in Database.PHIEUGHIDANHs
                   where (p.NgayGhiDanh.Value.Month == month) &&
                         (p.NgayGhiDanh.Value.Year == year)
                   select new BaoCaoHocVienGhiDanh()
                   {
                       MaHV = p.DANGKies.MaHV,
                       TenHV = p.DANGKies.HOCVIEN.TenHV,
                       GioiTinhHV = p.DANGKies.HOCVIEN.GioiTinhHV,
                       NgayGhiDanh = p.NgayGhiDanh,
                       TenKH = p.DANGKies.KHOAHOC.TenKH
                   };
        }

        /// Danh sách nợ học phí
        public static IQueryable<BaoCaoHocVienNo> ThongKeDanhSachNoHocPhi()
        {
            return (from p in Database.PHIEUGHIDANHs
                    where p.ConNo > 0
                    select new BaoCaoHocVienNo()
                    {
                        MaHV = p.DANGKies.MaHV,
                        TenHV = p.DANGKies.HOCVIEN.TenHV,
                        GioiTinhHV = p.DANGKies.HOCVIEN.GioiTinhHV,
                        TenKH = p.DANGKies.KHOAHOC.TenKH,
                        ConNo = p.ConNo
                    });
        }

        /// Chọn một phiếu ghi danh
        public static PHIEUGHIDANH Select(string maPhieu)
        {
            return (from p in Database.PHIEUGHIDANHs
                    where p.MaPhieu == maPhieu
                    select p).Single();
        }


        /// Thêm phiếu ghi danh
        public static void Insert(PHIEUGHIDANH p)
        {
            Database.PHIEUGHIDANHs.InsertOnSubmit(p);

            Database.SubmitChanges();
        }

        /// <summary>
        public static void Update(PHIEUGHIDANH ph)
        {
            PHIEUGHIDANH pCu = Select(ph.MaPhieu);

            pCu.NgayGhiDanh = ph.NgayGhiDanh;
            pCu.DaDong = ph.DaDong;
            pCu.ConNo = ph.ConNo;
            pCu.MaNV = ph.MaNV;

            Database.SubmitChanges();
        }

        /// Tự động sinh mã phiếu ghi danh
        public static string AutoGenerateId()
        {
            string result = "PG" + DateTime.Now.ToString("yyMMdd");
            var temp = from p in GlobalSettings.Database.PHIEUGHIDANHs
                       where p.MaPhieu.StartsWith(result)
                       select p.MaPhieu;
            int max = 0;

            foreach (var i in temp)
            {
                int j = int.Parse(i.Substring(8, 2));
                if (j > max) max = j;
            }

            return string.Format("{0}{1:D2}", result, max + 1);
        }
    }
}
