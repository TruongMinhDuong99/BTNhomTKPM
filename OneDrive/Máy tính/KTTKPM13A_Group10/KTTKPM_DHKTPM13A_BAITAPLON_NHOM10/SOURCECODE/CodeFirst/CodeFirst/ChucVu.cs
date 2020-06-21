using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class ChucVu
    {
        [Key]
        public string maChucVu { get; set; }
        public string tenChucVu { get; set; }
    }
}
