using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class DieuTri
    {
        [Key]
        public string maDieuTri { get; set; }
        public string maNhanVien { get; set; }
        public string maKhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
