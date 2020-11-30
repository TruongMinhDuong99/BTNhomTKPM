using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;
namespace DATA
{
    public class dalTieuDe
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public eTieuDe layTieuDeTheoMaTieuDe(string matd)
        {
            TieuDe td = db.TieuDes.Where(x => x.MaTieuDe.Equals(matd)).FirstOrDefault();
            eTieuDe etd = new eTieuDe();
            etd.MaTieuDe = td.MaTieuDe;
            etd.MaLoaiDia = td.MaLoaiDia;
            etd.TenTieuDe = td.TenTieuDe;
            etd.NhaSanXuat = td.NhaSanXuat;
            return etd;
        }
    }
}
