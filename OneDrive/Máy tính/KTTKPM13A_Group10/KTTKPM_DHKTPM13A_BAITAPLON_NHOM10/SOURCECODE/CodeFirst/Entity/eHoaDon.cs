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
    public class eHoaDon
    {
        [DataMember]
        public string maHoaDon { get; set; }
        [DataMember]
        public DateTime ngayTaoHoaDon { get; set; }
        [DataMember]
        public double thanhToan { get; set; }
        [DataMember]
        public double tongTien { get; set; }
        [DataMember]
        public string maDieuTri { get; set; }
        [DataMember]
        public string maNhanVien { get; set; }
    }
}
