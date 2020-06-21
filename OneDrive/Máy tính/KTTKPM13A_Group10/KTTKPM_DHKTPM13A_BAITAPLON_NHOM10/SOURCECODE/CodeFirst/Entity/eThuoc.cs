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
    public class eThuoc
    {
        [DataMember]
        public string maThuoc { get; set; }
        [DataMember]
        public string tenThuoc { get; set; }
        [DataMember]
        public string tacDung { get; set; }
        [DataMember]
        public string donVi { get; set; }

    }
}
