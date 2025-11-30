using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BusinessLogic.Properties;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public enum UserType { NhanVien, HocVien, GiangVien }
    public static class GlobalSettings
    {
        
        /// Đại diện cho cơ sở dữ liệu của chương trình
        
        public static QuanLyHocVienDataContext Database { get; set; }

        
        /// Đại diện cho chuỗi kết nối
        
        public static string ConnectionString { get; set; }

        
        /// Đại diện cho mã người dùng đăng nhập
        
        public static string UserID { get; set; }

        
        /// Đại diện cho tên người dùng đăng nhập
        
        public static string UserName { get; set; }

        
        /// Đại diện cho kiểu người dùng đăng nhập
        
        public static UserType UserType { get; set; }

        
        /// Đại diện cho tên server
        
        public static string ServerName { get; set; }

        
        /// Đại diện cho tên database
        
        public static string ServerCatalog { get; set; }

        
        /// Đại diện cho tên trung tâm
        
        public static string CenterName { get; set; }

        
        /// Đại diện cho địa chỉ trung tâm
        
        public static string CenterAddress { get; set; }

        
        /// Đại diện cho website trung tâm
        
        public static string CenterWebsite { get; set; }

        
        /// Đại diện cho email trung tâm
        
        public static string CenterEmail { get; set; }

        
        /// Đại diện cho số điện thoại trung tâm
        
        public static string CenterTelephone { get; set; }

        
        /// Đại diện cho danh sách quy định
        
        public static Dictionary<string,int> QuyDinh { get; set; }


        
        /// Kết nối đến cơ sở dữ liệu
        
        public static void ConnectToDatabase()
        {
            //nạp thông tin kết nối
            ConnectionString = Settings.Default.ConnectionString;
            ServerName = Settings.Default.Database_ServerName;
            ServerCatalog = Settings.Default.Database_ServerCatalog;

            Database = new QuanLyHocVienDataContext(ConnectionString);

            //kiểm tra kết nối
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select 1", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        
        /// Nạp thông tin trung tâm
        
        public static void LoadCenterInformation()
        {
            CenterName = "Trung Tâm Ngoại Ngữ";
            CenterAddress = "TP.HCM";
            CenterWebsite = "www.https://ttngoaingu.com.vn";
            CenterEmail = "english@gmail.com";
            CenterTelephone = "093.xxx.xxxx";
        }

        
        /// Lấy danh sách database
        
        /// <param name="connectionString">Chuỗi kết nối đến master</param>
        /// <returns></returns>
        public static List<string> GetDatabaseList(string connectionString)
        {
            List<string> list = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("sp_databases", con))
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                        list.Add(dr[0].ToString());
            }

            return list;
        }

        
        /// Lưu lại kết nối cơ sở dữ liệu
        
        public static void SaveDatabaseConnection()
        {
            Settings.Default.ConnectionString = ConnectionString;
            Settings.Default.Database_ServerName = ServerName;
            Settings.Default.Database_ServerCatalog = ServerCatalog;

            Settings.Default.Save();
        }

        
        /// Nạp danh sách quy định
        
        public static void LoadQuyDinh()
        {
            QuyDinh = new Dictionary<string, int>();

            var f = BusinessLogic.QuyDinh.SelectAll();

            foreach (var i in f)
                QuyDinh.Add(i.MaQD, (int)i.GiaTri);
        }
    }
}
