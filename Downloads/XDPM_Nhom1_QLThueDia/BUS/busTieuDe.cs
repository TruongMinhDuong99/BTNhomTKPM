using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busTieuDe
    {
        dalTieuDe dalTD = new dalTieuDe();
        public eTieuDe layTieuDeTheoMaTieuDe(string ma)
        {
            return dalTD.layTieuDeTheoMaTieuDe(ma);
        }
    }
}
