using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class AccessRestrictionDateType : DateType
    {
        public AccessRestrictionDateType()
        {
            this.Reason = new List<StructuredStringType>();
            this.User = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<StructuredStringType> Reason { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> User { get; set; }
    }
}