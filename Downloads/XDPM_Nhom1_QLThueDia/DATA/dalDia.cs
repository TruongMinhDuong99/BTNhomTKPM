using ENTITTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class dalDia
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public eDia layDiaTheoMa(string madia)
        {
            Dia d = db.Dias.Where(x => x.MaDia == madia).FirstOrDefault();
            eDia ed = new eDia();
            ed.Madia = d.MaDia;
            ed.Tendia = d.TenDia;
            ed.Matieude = d.MaTieuDe;
            ed.Trangthaidia = d.TrangThaiDia;
            return ed;
        }
        public List<eDia_LoaiDia_TieuDe> layTatCaDia()
        {
            var query = (from LoaiDia in db.LoaiDias
                        join TieuDe in db.TieuDes
                        on LoaiDia.MaLoaiDia equals TieuDe.MaLoaiDia
                        join Dia in db.Dias
                        on TieuDe.MaTieuDe equals Dia.MaTieuDe
                        select new
                        {
                            madianew = Dia.MaDia,
                            tenloaidianew = LoaiDia.TenLoaiDia,
                            tentieudenew = TieuDe.TenTieuDe,
                            tendianew = Dia.TenDia,
                            trangthaidianew = Dia.TrangThaiDia,
                        }).ToList();
            List<eDia_LoaiDia_TieuDe> l = new List<eDia_LoaiDia_TieuDe>();
            foreach (var item in query)
            {
                eDia_LoaiDia_TieuDe dulieulay = new eDia_LoaiDia_TieuDe();
                dulieulay.Madia = item.madianew;
                dulieulay.Tenloai = item.tenloaidianew;
                dulieulay.Tentieude = item.tentieudenew;
                dulieulay.Tendia = item.tendianew;
                dulieulay.Trangthai = item.trangthaidianew;
                l.Add(dulieulay);
            }
            return l;
        }
        public List<eDia_LoaiDia_TieuDe> layDanhSachDiaTheoLoai(string maLoai)
        {
            var query = from LoaiDia in db.LoaiDias
                        join TieuDe in db.TieuDes
                        on LoaiDia.MaLoaiDia equals TieuDe.MaLoaiDia
                        join Dia in db.Dias
                        on TieuDe.MaTieuDe equals Dia.MaTieuDe
                        where LoaiDia.MaLoaiDia == maLoai
                        select new
                        {
                            madianew=Dia.MaDia,
                            tenloaidianew=LoaiDia.TenLoaiDia,
                            tentieudenew=TieuDe.TenTieuDe,
                            tendianew=Dia.TenDia,
                            trangthaidianew=Dia.TrangThaiDia,
                        };
            List<eDia_LoaiDia_TieuDe> l = new List<eDia_LoaiDia_TieuDe>();
            foreach (var item in query)
            {
                eDia_LoaiDia_TieuDe dulieulay = new eDia_LoaiDia_TieuDe();
                dulieulay.Madia = item.madianew;
                dulieulay.Tenloai = item.tenloaidianew;
                dulieulay.Tentieude = item.tentieudenew;
                dulieulay.Tendia = item.tendianew;
                dulieulay.Trangthai = item.trangthaidianew;
                l.Add(dulieulay);
            }
            return l;
        }
        public List<eDia_LoaiDia_TieuDe> layDanhSachDiaTheoLoaiVaTheoTrangThai(string maLoai,string trangthai)
        {
            var query = from LoaiDia in db.LoaiDias
                        join TieuDe in db.TieuDes
                        on LoaiDia.MaLoaiDia equals TieuDe.MaLoaiDia
                        join Dia in db.Dias
                        on TieuDe.MaTieuDe equals Dia.MaTieuDe
                        where LoaiDia.MaLoaiDia == maLoai && Dia.TrangThaiDia==trangthai
                        select new
                        {
                            madianew = Dia.MaDia,
                            tenloaidianew = LoaiDia.TenLoaiDia,
                            tentieudenew = TieuDe.TenTieuDe,
                            tendianew = Dia.TenDia,
                            trangthaidianew = Dia.TrangThaiDia,
                        };
            List<eDia_LoaiDia_TieuDe> l = new List<eDia_LoaiDia_TieuDe>();
            foreach (var item in query)
            {
                eDia_LoaiDia_TieuDe dulieulay = new eDia_LoaiDia_TieuDe();
                dulieulay.Madia = item.madianew;
                dulieulay.Tenloai = item.tenloaidianew;
                dulieulay.Tentieude = item.tentieudenew;
                dulieulay.Tendia = item.tendianew;
                dulieulay.Trangthai = item.trangthaidianew;
                l.Add(dulieulay);
            }
            return l;
        }
        public int updateTrangThaiDiaChoDatTruoc(string madia)
        {
            Dia d = db.Dias.Where(x => x.MaDia == madia).FirstOrDefault();
            if (d == null)
                return 0;
            d.TrangThaiDia = "Đã đặt";
            db.SubmitChanges();
            return 1;
        }
        public int updateTrangThaiDiaTra(string madia)
        {
            Dia d = db.Dias.Where(x => x.MaDia == madia).FirstOrDefault();
            if (d == null)
                return 0;
            d.TrangThaiDia = "Trên kệ";
            db.SubmitChanges();
            return 1;
        }
    }
}
