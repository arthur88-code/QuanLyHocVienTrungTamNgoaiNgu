using System.Linq;
using DataAccess;
using static BusinessLogic.GlobalSettings;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    
    /// Mô tả chi tiết bảng điểm trên giao diện
    
    public struct BangDiemDetail
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string TenKH { get; set; }
        public DateTime? NgayBD { get; set; }
        public DateTime? NgayKT { get; set; }
        public int? SiSo { get; set; }
        public bool? DangMo { get; set; }
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public int DiemNghe { get; set; }
        public int DiemNoi { get; set; }
        public int DiemDoc { get; set; }
        public int DiemViet { get; set; }
        public double DiemTrungBinh { get; set; }
    }

    public struct BangDiemTrungBinh
    {
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public int DiemNghe { get; set; }
        public int DiemNoi { get; set; }
        public int DiemDoc { get; set; }
        public int DiemViet { get; set; }
        public double DiemTrungBinh { get; set; }
    }

    public static class BangDiem
    {
        
        /// Lấy chi tiết của một bảng điểm
        public static BangDiemDetail SelectDetail(string maHV, string maLop)
        {
            return (from p in Database.BANGDIEMs
                    where p.MaLop == maLop && p.MaHV == maHV
                    select new BangDiemDetail()
                    {
                        MaLop = p.MaLop,
                        TenLop = p.LOPHOC.TenLop,
                        TenKH = p.LOPHOC.KHOAHOC.TenKH,
                        NgayBD = p.LOPHOC.NgayBD,
                        NgayKT = p.LOPHOC.NgayKT,
                        SiSo = p.LOPHOC.SiSo,
                        DangMo = p.LOPHOC.DangMo,
                        MaHV = p.MaHV,
                        TenHV = p.HOCVIEN.TenHV,
                        DiemNghe = (int)p.DiemNghe,
                        DiemNoi = (int)p.DiemNoi,
                        DiemDoc = (int)p.DiemDoc,
                        DiemViet = (int)p.DiemViet,
                        DiemTrungBinh = (int)p.DiemNghe * (double)p.LOPHOC.KHOAHOC.HeSoNghe / 100 +
                                        (int)p.DiemNoi * (double)p.LOPHOC.KHOAHOC.HeSoNoi / 100 +
                                        (int)p.DiemDoc * (double)p.LOPHOC.KHOAHOC.HeSoDoc / 100 +
                                        (int)p.DiemViet * (double)p.LOPHOC.KHOAHOC.HeSoViet / 100
                    }).Single();
        }

        
        /// Chọn một bảng điểm
        public static BANGDIEM Select(string maHV, string maLop)
        {
            return (from p in Database.BANGDIEMs
                    where p.MaLop == maLop && p.MaHV == maHV
                    select p).Single();
        }

        
        /// Chọn danh sách học viên trong một lớp
        public static List<HOCVIEN> SelectDSHV(string maLop)
        {
            return (from p in Database.BANGDIEMs
                    where p.MaLop == maLop
                    select p.HOCVIEN).ToList();
        }

        
        /// Lấy danh sách lớp của học viên
        public static object SelectDSLop(string maHV, DateTime? tuNgay = null, DateTime? denNgay = null, string maKH = null)
        {
            return (from p in Database.BANGDIEMs
                    where p.MaHV == maHV &&
                        (tuNgay == null ? true : p.LOPHOC.NgayBD >= tuNgay) &&
                        (denNgay == null ? true : p.LOPHOC.NgayKT <= denNgay) &&
                        (maKH == null ? true : p.LOPHOC.MaKH == maKH)
                    select new
                    {
                        MaLop = p.MaLop,
                        TenLop = p.LOPHOC.TenLop,
                    }).ToList();
        }

        
        /// Tổng nợ tất cả các lớp đã học
        public static decimal TongNoCacLop(string maHV)
        {
            var f = from p in Database.BANGDIEMs
                    where p.MaHV == maHV
                    select p;

            decimal result = 0;
            foreach (var i in f)
                result += (decimal)i.PHIEUGHIDANH.ConNo;

            return result;
        }

        
        /// Lấy bảng điểm trung bình của lớp
        public static IQueryable<BangDiemTrungBinh> SelectBangDiemLop(string maLop)
        {
            return (from p in Database.BANGDIEMs
                    where p.MaLop == maLop
                    select new BangDiemTrungBinh()
                    {
                        MaHV = p.MaHV,
                        TenHV = p.HOCVIEN.TenHV,
                        DiemNghe = (int)p.DiemNghe,
                        DiemNoi = (int)p.DiemNoi,
                        DiemDoc = (int)p.DiemDoc,
                        DiemViet = (int)p.DiemViet,
                        DiemTrungBinh = (int)p.DiemNghe * (double)p.LOPHOC.KHOAHOC.HeSoNghe / 100 +
                                        (int)p.DiemNoi * (double)p.LOPHOC.KHOAHOC.HeSoNoi / 100 +
                                        (int)p.DiemDoc * (double)p.LOPHOC.KHOAHOC.HeSoDoc / 100 +
                                        (int)p.DiemViet * (double)p.LOPHOC.KHOAHOC.HeSoViet / 100
                    });
        }

        
        /// Thêm một bảng điểm
        public static void Insert(BANGDIEM bd)
        {
            Database.BANGDIEMs.InsertOnSubmit(bd);
            Database.SubmitChanges();
        }

        
        /// Cập nhật bảng điểm
        public static void Update(BANGDIEM b)
        {
            var temp = Select(b.MaHV, b.MaLop);

            temp.DiemNghe = b.DiemNghe;
            temp.DiemNoi = b.DiemNoi;
            temp.DiemDoc = b.DiemDoc;
            temp.DiemViet = b.DiemViet;

            Database.SubmitChanges();
        }

        
        /// Tìm danh sách học viên nợ học phí
        public static object DanhSachNoHocPhi(string maHV = null, string tenHV = null, string gioiTinh = null, decimal? _from = null, decimal? _to = null)
        {
            return (from p in Database.BANGDIEMs
                    where p.PHIEUGHIDANH.ConNo > 0 &&
                          (maHV == null ? true : p.MaHV.Contains(maHV)) &&
                          (tenHV == null ? true : p.HOCVIEN.TenHV.Contains(tenHV)) &&
                          (gioiTinh == null ? true : p.HOCVIEN.GioiTinhHV == gioiTinh) &&
                          (_from == null || _to == null ? true : p.PHIEUGHIDANH.ConNo >= _from && p.PHIEUGHIDANH.ConNo <= _to)
                    select new
                    {
                        MaHV = p.MaHV,
                        TenHV = p.HOCVIEN.TenHV,
                        GioiTinhHV = p.HOCVIEN.GioiTinhHV,
                        MaLop = p.MaLop,
                        ConNo = p.PHIEUGHIDANH.ConNo,
                        MaPhieu = p.MaPhieu
                    }).ToList();
        }
    }
}
