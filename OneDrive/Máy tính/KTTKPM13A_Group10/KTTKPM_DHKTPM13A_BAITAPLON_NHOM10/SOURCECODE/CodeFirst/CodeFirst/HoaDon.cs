using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class HoaDon
    {
        [Key]
        public string maHoaDon { get; set; }
        public DateTime ngayTaoHoaDon { get; set; }
        public double thanhToan { get; set; }
        public double tongTien { get; set; }
        public string maDieuTri { get; set; }
        public string maNhanVien { get; set; }
        public virtual DieuTri DieuTri { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
