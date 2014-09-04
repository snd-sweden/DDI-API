using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class PositionType
    {
        public PositionType()
        {
            this.Period = new List<DateType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Title { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType OrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<DateType> Period { get; set; }
    }
}