using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;

namespace BusinessLogic
{
    public static class LoaiHV
    {
        /// Chọn tất cả
        public static List<LOAIHV> SelectAll()
        {
            var result = from p in GlobalSettings.Database.LOAIHVs
                         select p;

            return result.ToList();
        }
    }
}
