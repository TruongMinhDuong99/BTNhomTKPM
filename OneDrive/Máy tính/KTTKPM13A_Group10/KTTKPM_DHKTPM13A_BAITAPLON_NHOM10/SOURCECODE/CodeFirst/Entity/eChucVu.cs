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
    public class eChucVu
    {
        [DataMember]
        public string maChucVu { get; set; }
        [DataMember]
        public string tenChucVu { get; set; }
    }
}
