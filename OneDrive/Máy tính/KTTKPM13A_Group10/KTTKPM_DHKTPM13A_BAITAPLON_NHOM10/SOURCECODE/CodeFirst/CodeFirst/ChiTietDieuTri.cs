using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class ChiTietDieuTri
    {
        [Key]
        [Column(Order = 1)]
        public string maDieuTri { get; set; }
        [Key]
        [Column(Order = 2)]
        public string maDichVu { get; set; }
        public string chuanDoan { get; set; }
        public int soLuongRang { get; set; }
        public string tenRang { get; set; }
        public virtual DichVu DichVu { get; set; }
        public virtual DieuTri DieuTri { get; set; }
    }
}
