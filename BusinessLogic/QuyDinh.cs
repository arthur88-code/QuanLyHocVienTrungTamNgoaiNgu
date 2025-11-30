using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BusinessLogic.GlobalSettings;
using DataAccess;

namespace BusinessLogic
{
    public static class QuyDinh
    {
        /// Chọn tất cả các quy định
        public static List<QUYDINH> SelectAll()
        {
            return (from p in Database.QUYDINHs
                    select p).ToList();
        }

        /// Chọn một quy định
        public static QUYDINH Select(string maQD)
        {
            return (from p in Database.QUYDINHs
                    where p.MaQD == maQD
                    select p).Single();
        }

        /// Cập nhật một quy định
        public static void Update(QUYDINH qd)
        {
            var qdCu = Select(qd.MaQD);
            qdCu.GiaTri = qd.GiaTri;

            Database.SubmitChanges();
        }
    }
}
