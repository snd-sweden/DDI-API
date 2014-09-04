using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class StructuredMixedResponseDomainType
    {
        public StructuredMixedResponseDomainType()
        {
            this.ResponseTextSet = new List<ResponseTextSetType>();
            this.ResponseDomainInMixed = new ResponseDomainInMixedType();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ResponseTextSetType> ResponseTextSet { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public ResponseDomainInMixedType ResponseDomainInMixed { get; set; }
    }
}