using ENTITTY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DATA
{
    public class dalPhieuThue
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public ePhieuThue layPhieuThueTheoDiaDangThue(string madia)
        {
            ePhieuThue phieuthuenhan = new ePhieuThue();
            PhieuThue phieutim = db.PhieuThues.Where(x => x.MaDia == madia && x.TrangThaiThue=="Đang thuê").FirstOrDefault();
            if (phieutim == null)
                return null;
            phieuthuenhan.Maphieuthue = phieutim.MaThue;
            phieuthuenhan.Madia = phieutim.MaDia;
            phieuthuenhan.Makhachhang = phieutim.MaKhachHang;
            phieuthuenhan.Ngaymuon = phieutim.NgayMuon;
            phieuthuenhan.Ngaytra = phieutim.NgayTra;
            phieuthuenhan.Ngayhentra = phieutim.NgayHenTra;
            phieuthuenhan.Phitramuon = phieutim.PhiTraMuon;
            phieuthuenhan.Giathue = phieutim.GiaThue;
            phieuthuenhan.Trangthaiphi = phieutim.TrangThaiPhi;
            phieuthuenhan.Trangthaithue = phieutim.TrangThaiThue;
            return phieuthuenhan;
        }
        public ePhieuThue layPhieuThueTheoMaPhieu(string ma)
        {
            PhieuThue pt = db.PhieuThues.Where(x => x.MaThue == ma).FirstOrDefault();
            ePhieuThue pt1 = new ePhieuThue();
            pt1.Maphieuthue = pt.MaThue;
            pt1.Madia = pt.MaDia;
            pt1.Makhachhang = pt.MaKhachHang;
            pt1.Ngayhentra = pt.NgayHenTra;
            pt1.Ngaymuon = pt.NgayMuon;
            pt1.Ngaytra = pt.NgayTra;
            pt1.Trangthaiphi = pt.TrangThaiPhi;
            pt1.Trangthaithue = pt.TrangThaiThue;
            pt1.Giathue = pt.GiaThue;
            pt1.Phitramuon = pt.PhiTraMuon;
            return pt1;
        }
        public eDia_LoaiDia_TieuDe layPhiTraMuon(string madia)
        {
            var query = from PhieuThue in db.PhieuThues
                        join Dia in db.Dias
                        on PhieuThue.MaDia equals Dia.MaDia
                        join TieuDe in db.TieuDes
                        on Dia.MaTieuDe equals TieuDe.MaTieuDe
                        join LoaiDia in db.LoaiDias
                        on TieuDe.MaLoaiDia equals LoaiDia.MaLoaiDia
                        where (PhieuThue.MaDia == madia)
                        select new
                        {
                            madianew = Dia.MaDia,
                            matieudenew=TieuDe.MaTieuDe,
                            maloainew=LoaiDia.MaLoaiDia,
                            giaphatnew=LoaiDia.GiaPhat
                        };
            eDia_LoaiDia_TieuDe dulieulay = new eDia_LoaiDia_TieuDe();
            foreach (var item in query)
            {
                dulieulay.Madia = item.madianew;
                dulieulay.Maloaidia = item.maloainew;
                dulieulay.Matieude = item.matieudenew;
                dulieulay.Giaphat = item.giaphatnew;
            }
            return dulieulay;
        }
        public List<eDia_LoaiDia_TieuDe> chiTietTraMuon(string makh)
        {
            var query = from PhieuThue in db.PhieuThues
                        join Dia in db.Dias
                        on PhieuThue.MaDia equals Dia.MaDia
                        join TieuDe in db.TieuDes
                        on Dia.MaTieuDe equals TieuDe.MaTieuDe
                        join LoaiDia in db.LoaiDias
                        on TieuDe.MaLoaiDia equals LoaiDia.MaLoaiDia
                        where (PhieuThue.MaKhachHang == makh && PhieuThue.TrangThaiPhi.Equals("Chưa trả"))
                        select new
                        {
                            maphieunew = PhieuThue.MaThue,
                            tentieudenew = TieuDe.TenTieuDe,
                            tendianew = Dia.TenDia,
                            ngaythuenew = PhieuThue.NgayMuon,
                            ngayhentranew = PhieuThue.NgayHenTra,
                            ngaytranew=PhieuThue.NgayTra,
                            giaphatnew = PhieuThue.PhiTraMuon
                        };
            List<eDia_LoaiDia_TieuDe> lstChiTiet = new List<eDia_LoaiDia_TieuDe>();
            foreach (var item in query)
            {
                eDia_LoaiDia_TieuDe chitiet = new eDia_LoaiDia_TieuDe();
                chitiet.Maphieu = item.maphieunew;
                chitiet.Tentieude = item.tentieudenew;
                chitiet.Tendia = item.tendianew;
                chitiet.Ngaythue = item.ngaythuenew;
                chitiet.Ngayhentra = item.ngayhentranew;
                chitiet.NgayTra =DateTime.Parse(item.ngaytranew.ToString());
                chitiet.Giaphat =Double.Parse(item.giaphatnew.ToString());
                lstChiTiet.Add(chitiet);
            }
            return lstChiTiet;
        }
        public eKhachHang layKhachHangTheoPhieu(string makhachhang)
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
        public int updatePhiTraMuonCu(string maphieu)
        {
            PhieuThue pt = db.PhieuThues.Where(x => x.MaThue == maphieu).FirstOrDefault();
            if (pt == null)
            {
                return 0;
            }
            else
            {
                pt.TrangThaiPhi = "Đã trả";
                db.SubmitChanges();
                return 1;
            }
        }
        public int updatePhiTraMuonMoiCoTraPhi(string maphieu, double phitramuon)
        {
            PhieuThue pt = db.PhieuThues.Where(x => x.MaThue == maphieu).FirstOrDefault();
            if (pt == null)
            {
                return 0;
            }
            else
            {
                pt.TrangThaiThue = "Đã trả";
                pt.NgayTra = DateTime.Today;
                pt.PhiTraMuon = phitramuon;
                pt.TrangThaiPhi = "Đã trả";
                db.SubmitChanges();
                return 1;
            }
        }
        public int updatePhiTraMuonMoiKhongTraPhi(string maphieu, double phitramuon)
        {
            PhieuThue pt = db.PhieuThues.Where(x => x.MaThue == maphieu).FirstOrDefault();
            if (pt == null)
            {
                return 0;
            }
            else
            {
                pt.TrangThaiThue = "Đã trả";
                pt.NgayTra = DateTime.Today;
                pt.PhiTraMuon = phitramuon;
                pt.TrangThaiPhi = "Chưa trả";
                db.SubmitChanges();
                return 1;
            }
        }
        public int updatePhiTraMuonThanhToanSau(string maphieu,double phitramuon)
        {
            PhieuThue pt = db.PhieuThues.Where(x => x.MaThue == maphieu).FirstOrDefault();
            if (pt == null)
            {
                return 0;
            }
            else
            {
                pt.NgayTra = DateTime.Today;
                pt.PhiTraMuon = phitramuon;
                pt.TrangThaiPhi = "Chưa trả";
                db.SubmitChanges();
                return 1;
            }
        }
        public List<ePhieuThue> layDanhSachPhiMuonChuaThanhToanTheoKhachHang(string makh)
        {
            List<PhieuThue> l1 = db.PhieuThues.Where(x => x.MaKhachHang.Equals(makh) && x.TrangThaiPhi.Equals("Chưa trả")).ToList();
            List<ePhieuThue> l = new List<ePhieuThue>();
            //ePhieuThue pt = new ePhieuThue();
            foreach (var item in l1)
            {
                ePhieuThue pt = new ePhieuThue();
                pt.Madia = item.MaDia;
                pt.Makhachhang = item.MaKhachHang;
                pt.Maphieuthue = item.MaThue;
                pt.Trangthaiphi = item.TrangThaiPhi;
                pt.Trangthaithue = item.TrangThaiThue;
                pt.Ngayhentra = item.NgayHenTra;
                pt.Ngaymuon = item.NgayMuon;
                pt.Ngaytra = item.NgayTra;
                pt.Phitramuon = item.PhiTraMuon;
                pt.Giathue = item.GiaThue;
                l.Add(pt);
            }
            return l;
        }
    }
}
