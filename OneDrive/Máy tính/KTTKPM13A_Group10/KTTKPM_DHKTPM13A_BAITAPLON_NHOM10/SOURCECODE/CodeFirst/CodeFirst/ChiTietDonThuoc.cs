using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class ChiTietDonThuoc
    {
        [Key]
        [Column(Order = 1)]
        public string maThuoc { get; set; }
        [Key]
        [Column(Order = 2)]
        public string maDonThuoc { get; set; }
        public string cachDung { get; set; }
        public int soLuong { get; set; }
        public virtual Thuoc Thuoc { get; set; }
        public virtual DonThuoc DonThuoc { get; set; }
    }
}
