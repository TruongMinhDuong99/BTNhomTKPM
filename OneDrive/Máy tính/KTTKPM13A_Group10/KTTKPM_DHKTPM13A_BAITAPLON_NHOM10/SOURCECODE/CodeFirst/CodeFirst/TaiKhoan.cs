using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class TaiKhoan
    {
        [Key]
        public string maTaiKhoan { get; set; }
        public string matKhau { get; set; }
        public string tenTaiKhoan { get; set; }
    }
}
