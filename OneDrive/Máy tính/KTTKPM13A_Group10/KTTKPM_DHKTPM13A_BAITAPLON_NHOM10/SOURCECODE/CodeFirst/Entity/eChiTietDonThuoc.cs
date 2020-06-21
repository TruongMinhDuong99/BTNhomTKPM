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
    public class eChiTietDonThuoc
    {
        [DataMember]
        public string maThuoc { get; set; }
        [DataMember]
        public string maDonThuoc { get; set; }
        [DataMember]
        public string cachDung { get; set; }
        [DataMember]
        public int soLuong { get; set; }
    }
}
