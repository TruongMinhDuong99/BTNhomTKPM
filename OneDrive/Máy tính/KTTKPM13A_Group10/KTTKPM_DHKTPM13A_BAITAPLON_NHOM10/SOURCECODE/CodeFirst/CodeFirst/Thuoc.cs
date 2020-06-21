using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Thuoc
    {
        [Key]
        public string maThuoc { get; set; }
        public string tenThuoc { get; set; }
        public string tacDung { get; set; }
        public string donVi { get; set; }
    }
}
