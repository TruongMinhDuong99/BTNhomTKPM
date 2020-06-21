using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class PhongNhaContext : DbContext
    {
        public PhongNhaContext() : base("PhongKhamNhaContext")
        {

        }
        public virtual DbSet<ChiTietDieuTri> ChiTietDieuTris { get; set; }
        public virtual DbSet<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DieuTri> DieuTris { get; set; }
        public virtual DbSet<DonThuoc> DonThuocs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
    }
}
