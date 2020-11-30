using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;
namespace DATA
{
    public class dalPhieuDat
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public List<ePhieuDat> layDanhSachPhieuDatTheoTieuDeDat(string matd)
        {
            List<PhieuDat> l = db.PhieuDats.Where(x => x.MaTieuDe == matd && x.TrangThai=="Đang đặt").OrderBy(x=>x.NgayDat).ToList();
            List<ePhieuDat> lstPhieuDatLay = new List<ePhieuDat>();
            foreach (var item in l)
            {
                ePhieuDat phieu = new ePhieuDat();
                //phieu.Madia = item.madianew;
                phieu.MaTieuDe = item.MaTieuDe;
                phieu.MaDia = item.MaDia;
                phieu.MaKhachHang = item.MaKhachHang;
                phieu.MaPhieuDat = item.MaDat;
                phieu.NgayDat = item.NgayDat;
                phieu.TrangThai = item.TrangThai;
                lstPhieuDatLay.Add(phieu);
            }
            return lstPhieuDatLay;
        }
        public ePhieuDat layPhieuDatTheoMa(string maphieudat)
        {
            PhieuDat pd = db.PhieuDats.Where(x => x.MaDat.Equals(maphieudat)).FirstOrDefault();
            ePhieuDat phieu = new ePhieuDat();
            phieu.MaTieuDe = pd.MaTieuDe;
            phieu.MaDia = pd.MaDia;
            phieu.MaKhachHang = pd.MaKhachHang;
            phieu.MaPhieuDat = pd.MaDat;
            phieu.NgayDat = pd.NgayDat;
            phieu.TrangThai = pd.TrangThai;
            return phieu;
        }
        public int updateGanDiaChoPhieuDatTruoc(string maphieu, string madia)
        {
            PhieuDat pd = db.PhieuDats.Where(x => x.MaDat.Equals(maphieu)).FirstOrDefault();
            if (pd == null)
                return 0;
            pd.MaDia = madia;
            pd.TrangThai = "Đã có đĩa";
            db.SubmitChanges();
            return 1;
        }
        public int xoaDatTruoc(string maphieu)
        {
            PhieuDat pd = db.PhieuDats.Where(x => x.MaDat.Equals(maphieu)).FirstOrDefault();
            if (pd == null)
                return 0;
            db.PhieuDats.DeleteOnSubmit(pd);
            db.SubmitChanges();
            return 1;
        }
    }
}
