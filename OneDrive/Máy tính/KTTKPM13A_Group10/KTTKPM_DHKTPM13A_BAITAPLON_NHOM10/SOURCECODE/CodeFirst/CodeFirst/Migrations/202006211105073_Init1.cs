namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDieuTris",
                c => new
                    {
                        maDieuTri = c.String(nullable: false, maxLength: 128),
                        maDichVu = c.String(nullable: false, maxLength: 128),
                        chuanDoan = c.String(),
                        soLuongRang = c.Int(nullable: false),
                        tenRang = c.String(),
                    })
                .PrimaryKey(t => new { t.maDieuTri, t.maDichVu })
                .ForeignKey("dbo.DichVus", t => t.maDichVu, cascadeDelete: true)
                .ForeignKey("dbo.DieuTris", t => t.maDieuTri, cascadeDelete: true)
                .Index(t => t.maDichVu)
                .Index(t => t.maDieuTri);
            
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        maDichVu = c.String(nullable: false, maxLength: 128),
                        tenDichVu = c.String(),
                        donGia = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.maDichVu);
            
            CreateTable(
                "dbo.DieuTris",
                c => new
                    {
                        maDieuTri = c.String(nullable: false, maxLength: 128),
                        maNhanVien = c.String(maxLength: 128),
                        maKhachHang = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maDieuTri)
                .ForeignKey("dbo.KhachHangs", t => t.maKhachHang)
                .ForeignKey("dbo.NhanViens", t => t.maNhanVien)
                .Index(t => t.maKhachHang)
                .Index(t => t.maNhanVien);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        maKhachHang = c.String(nullable: false, maxLength: 128),
                        email = c.String(),
                        CMND = c.String(),
                        diaChi = c.String(),
                        gioiTinh = c.Boolean(nullable: false),
                        tenKH = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        soDienThoai = c.String(),
                    })
                .PrimaryKey(t => t.maKhachHang);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        maNhanVien = c.String(nullable: false, maxLength: 128),
                        email = c.String(),
                        CMND = c.String(),
                        diaChi = c.String(),
                        gioiTinh = c.Boolean(nullable: false),
                        tenKH = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        soDienThoai = c.String(),
                        chuyenMon = c.String(),
                        maTaiKhoan = c.String(maxLength: 128),
                        maChucVu = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maNhanVien)
                .ForeignKey("dbo.ChucVus", t => t.maChucVu)
                .ForeignKey("dbo.TaiKhoans", t => t.maTaiKhoan)
                .Index(t => t.maChucVu)
                .Index(t => t.maTaiKhoan);
            
            CreateTable(
                "dbo.ChucVus",
                c => new
                    {
                        maChucVu = c.String(nullable: false, maxLength: 128),
                        tenChucVu = c.String(),
                    })
                .PrimaryKey(t => t.maChucVu);
            
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        maTaiKhoan = c.String(nullable: false, maxLength: 128),
                        matKhau = c.String(),
                        tenTaiKhoan = c.String(),
                    })
                .PrimaryKey(t => t.maTaiKhoan);
            
            CreateTable(
                "dbo.ChiTietDonThuocs",
                c => new
                    {
                        maThuoc = c.String(nullable: false, maxLength: 128),
                        maDonThuoc = c.String(nullable: false, maxLength: 128),
                        cachDung = c.String(),
                        soLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.maThuoc, t.maDonThuoc })
                .ForeignKey("dbo.DonThuocs", t => t.maDonThuoc, cascadeDelete: true)
                .ForeignKey("dbo.Thuocs", t => t.maThuoc, cascadeDelete: true)
                .Index(t => t.maDonThuoc)
                .Index(t => t.maThuoc);
            
            CreateTable(
                "dbo.DonThuocs",
                c => new
                    {
                        maDonThuoc = c.String(nullable: false, maxLength: 128),
                        ghiChu = c.String(),
                        ngayTaoDonThuoc = c.DateTime(nullable: false),
                        chuanDoan = c.String(),
                        maNhanVien = c.String(maxLength: 128),
                        maKhachHang = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maDonThuoc)
                .ForeignKey("dbo.KhachHangs", t => t.maKhachHang)
                .ForeignKey("dbo.NhanViens", t => t.maNhanVien)
                .Index(t => t.maKhachHang)
                .Index(t => t.maNhanVien);
            
            CreateTable(
                "dbo.Thuocs",
                c => new
                    {
                        maThuoc = c.String(nullable: false, maxLength: 128),
                        tenThuoc = c.String(),
                        tacDung = c.String(),
                        donVi = c.String(),
                    })
                .PrimaryKey(t => t.maThuoc);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        maHoaDon = c.String(nullable: false, maxLength: 128),
                        ngayTaoHoaDon = c.DateTime(nullable: false),
                        thanhToan = c.Double(nullable: false),
                        tongTien = c.Double(nullable: false),
                        maDieuTri = c.String(maxLength: 128),
                        maNhanVien = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maHoaDon)
                .ForeignKey("dbo.DieuTris", t => t.maDieuTri)
                .ForeignKey("dbo.NhanViens", t => t.maNhanVien)
                .Index(t => t.maDieuTri)
                .Index(t => t.maNhanVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "maNhanVien", "dbo.NhanViens");
            DropForeignKey("dbo.HoaDons", "maDieuTri", "dbo.DieuTris");
            DropForeignKey("dbo.ChiTietDonThuocs", "maThuoc", "dbo.Thuocs");
            DropForeignKey("dbo.ChiTietDonThuocs", "maDonThuoc", "dbo.DonThuocs");
            DropForeignKey("dbo.DonThuocs", "maNhanVien", "dbo.NhanViens");
            DropForeignKey("dbo.DonThuocs", "maKhachHang", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDieuTris", "maDieuTri", "dbo.DieuTris");
            DropForeignKey("dbo.DieuTris", "maNhanVien", "dbo.NhanViens");
            DropForeignKey("dbo.NhanViens", "maTaiKhoan", "dbo.TaiKhoans");
            DropForeignKey("dbo.NhanViens", "maChucVu", "dbo.ChucVus");
            DropForeignKey("dbo.DieuTris", "maKhachHang", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDieuTris", "maDichVu", "dbo.DichVus");
            DropIndex("dbo.HoaDons", new[] { "maNhanVien" });
            DropIndex("dbo.HoaDons", new[] { "maDieuTri" });
            DropIndex("dbo.ChiTietDonThuocs", new[] { "maThuoc" });
            DropIndex("dbo.ChiTietDonThuocs", new[] { "maDonThuoc" });
            DropIndex("dbo.DonThuocs", new[] { "maNhanVien" });
            DropIndex("dbo.DonThuocs", new[] { "maKhachHang" });
            DropIndex("dbo.ChiTietDieuTris", new[] { "maDieuTri" });
            DropIndex("dbo.DieuTris", new[] { "maNhanVien" });
            DropIndex("dbo.NhanViens", new[] { "maTaiKhoan" });
            DropIndex("dbo.NhanViens", new[] { "maChucVu" });
            DropIndex("dbo.DieuTris", new[] { "maKhachHang" });
            DropIndex("dbo.ChiTietDieuTris", new[] { "maDichVu" });
            DropTable("dbo.HoaDons");
            DropTable("dbo.Thuocs");
            DropTable("dbo.DonThuocs");
            DropTable("dbo.ChiTietDonThuocs");
            DropTable("dbo.TaiKhoans");
            DropTable("dbo.ChucVus");
            DropTable("dbo.NhanViens");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DieuTris");
            DropTable("dbo.DichVus");
            DropTable("dbo.ChiTietDieuTris");
        }
    }
}
