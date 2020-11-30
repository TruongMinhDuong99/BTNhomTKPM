using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busPhieuDat
    {
        dalPhieuDat dalPD = new dalPhieuDat();
        public List<ePhieuDat> layDanhSachPhieuDatTheoDiaTra(string matd)
        {
            return dalPD.layDanhSachPhieuDatTheoTieuDeDat(matd);
        }
        public ePhieuDat layPhieuDatTheoMa(string maphieudat)
        {
            return dalPD.layPhieuDatTheoMa(maphieudat);
        }
        public int updateGanDiaChoPhieuDatTruoc(string maphieu, string madia)
        {
            return dalPD.updateGanDiaChoPhieuDatTruoc(maphieu, madia);
        }
        public int xoaDatTruoc(string maphieu)
        {
            return dalPD.xoaDatTruoc(maphieu);
        }
    }
}
