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
    public class eDieuTri
    {
        [DataMember]
        public string maDieuTri { get; set; }
        [DataMember]
        public string maNhanVien { get; set; }
        [DataMember]
        public string maKhachHang { get; set; }
    }
}
