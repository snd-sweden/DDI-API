using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ReferenceDateType : DateType
    {
        public ReferenceDateType()
        {
            this.Subject = new List<InternationalCodeValueType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalCodeValueType> Subject { get; set; }

    }
}