using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class SchemeReferenceType : ReferenceType
    {
        public SchemeReferenceType()
        {
            this.Exclude = new List<ExcludeType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ExcludeType> Exclude { get; set; }
    }
}