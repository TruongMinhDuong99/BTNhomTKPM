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
    public class eTaiKhoan
    {
        [DataMember]
        public string maTaiKhoan { get; set; }
        [DataMember]
        public string matKhau { get; set; }
        [DataMember]
        public string tenTaiKhoan { get; set; }
    }
}
