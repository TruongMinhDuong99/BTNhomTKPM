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
    public class eChiTietDieuTri
    {
        [DataMember]
        public string maDieuTri { get; set; }
        [DataMember]
        public string maDichVu { get; set; }
        [DataMember]
        public string chuanDoan { get; set; }
        [DataMember]
        public int soLuongRang { get; set; }
        [DataMember]
        public string tenRang { get; set; }
    }
}
