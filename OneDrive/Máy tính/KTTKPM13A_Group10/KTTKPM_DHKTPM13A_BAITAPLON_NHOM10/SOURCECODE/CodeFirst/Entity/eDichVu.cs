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
    public class eDichVu
    {
        [DataMember]
        public string maDichVu { get; set; }
        [DataMember]
        public string tenDichVu { get; set; }
        [DataMember]
        public double donGia { get; set; }
    }
}
