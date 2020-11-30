using ENTITTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class dalLoaiDia
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public List<eLoaiDia> layDanhSachLoaiDia()
        {
            List<eLoaiDia> l1 = new List<eLoaiDia>();
            List<LoaiDia> l = db.LoaiDias.ToList();
            foreach (var item in l)
            {
                eLoaiDia eld = new eLoaiDia();
                eld.maLoai = item.MaLoaiDia;
                eld.tenLoai = item.TenLoaiDia;
                eld.thoiGianThue = item.ThoiGianThue;
                eld.giaThue = item.GiaThue;
                eld.giaPhat = item.GiaPhat;
                l1.Add(eld);
            }
            return l1;
        }
    }
}
