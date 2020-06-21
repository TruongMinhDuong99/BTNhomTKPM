using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class DichVu
    {
        [Key]
        public string maDichVu { get; set; }
        public string tenDichVu { get; set; }
        public double donGia { get; set; }
    }
}
