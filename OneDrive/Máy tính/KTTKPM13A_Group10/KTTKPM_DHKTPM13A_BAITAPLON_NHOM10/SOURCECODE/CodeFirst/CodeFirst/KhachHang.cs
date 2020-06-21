using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class KhachHang
    {
        [Key]
        public string maKhachHang { get; set; }
        public string email { get; set; }
        public string CMND { get; set; }
        public string diaChi { get; set; }
        public Boolean gioiTinh { get; set; }
        public string tenKH { get; set; }
        public DateTime ngaySinh { get; set; }
        public string soDienThoai { get; set; }
    }
}
