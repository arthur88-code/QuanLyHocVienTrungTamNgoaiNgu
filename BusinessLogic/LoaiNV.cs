using System.Collections.Generic;
using System.Linq;
using DataAccess;
using static BusinessLogic.GlobalSettings;

namespace BusinessLogic
{
    public static class LoaiNV
    {
        /// Chọn tất cả loại nhân viên
        public static List<LOAINV> SelectAll()
        {
            return (from p in Database.LOAINVs
                    select p).ToList();
        }
    }
}
