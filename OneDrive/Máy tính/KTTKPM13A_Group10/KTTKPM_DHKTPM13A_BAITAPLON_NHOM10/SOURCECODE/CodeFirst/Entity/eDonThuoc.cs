using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Entity
{
    [DataContract]
    public class eDonThuoc
    {
        [DataMember]
        public string maDonThuoc { get; set; }
        [DataMember]
        public string ghiChu { get; set; }
        [DataMember]
        public DateTime ngayTaoDonThuoc { get; set; }
        [DataMember]
        public string chuanDoan { get; set; }
        [DataMember]
        public string maNhanVien { get; set; }
        [DataMember]
        public string maKhachHang { get; set; }
    }
}
