using ENTITTY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class dalKhachHang
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public List<eKhachHang> layDanhSachKhachHang()
        {
            List<eKhachHang> l1 = new List<eKhachHang>();
            List<KhachHang> l = db.KhachHangs.ToList();
            foreach (var item in l)
            {
                eKhachHang khachhang = new eKhachHang();
                khachhang.Makh = item.MaKhachHang;
                khachhang.Tenkh = item.HoTen;
                khachhang.Diachi = item.DiaChi;
                khachhang.Sodt = item.SDT;
                l1.Add(khachhang);
            }
            return l1;
        }

        public eKhachHang layKhachHangTheoMaKhachHang(string makhachhang)
        {
            eKhachHang khachhang = new eKhachHang();
            KhachHang khtim = db.KhachHangs.Where(x => x.MaKhachHang == makhachhang).FirstOrDefault();
            if (khtim == null)
                return null;
            khachhang.Makh = khtim.MaKhachHang;
            khachhang.Tenkh = khtim.HoTen;
            khachhang.Diachi = khtim.DiaChi;
            khachhang.Sodt = khtim.SDT;
            return khachhang;
        }
    }
}
