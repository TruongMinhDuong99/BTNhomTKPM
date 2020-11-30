using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busDia
    {
        dalDia dalDIA = new dalDia();
        public eDia layDiaTheoMa(string madia)
        {
            return dalDIA.layDiaTheoMa(madia);
        }
        public List<eDia_LoaiDia_TieuDe> layDiaTheoLoaiDia(string maloai)
        {
            return dalDIA.layDanhSachDiaTheoLoai(maloai);
        }
        public List<eDia_LoaiDia_TieuDe> layToanBoDia()
        {
            return dalDIA.layTatCaDia();
        }
        public List<eDia_LoaiDia_TieuDe> layDiaTheoLoaiDiaVaTrangThai(string maloai,string trangthai)
        {
            return dalDIA.layDanhSachDiaTheoLoaiVaTheoTrangThai(maloai,trangthai);
        }
        public int updateTrangThaiDiaChoDatTruoc(string madia)
        {
            return dalDIA.updateTrangThaiDiaChoDatTruoc(madia);
        }
        public int updateTrangThaiDiaTra(string madia)
        {
            return dalDIA.updateTrangThaiDiaTra(madia);
        }

    }
}
