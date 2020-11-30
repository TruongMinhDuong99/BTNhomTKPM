using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busLoaiDia
    {
        dalLoaiDia dalld = new dalLoaiDia();
        public List<eLoaiDia> layDanhSachLoaiDia()
        {
            return dalld.layDanhSachLoaiDia();
        }
    }
}
