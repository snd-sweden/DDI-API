using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CohortType
    {
        public CohortType()
        {
            this.Range = new List<RangeType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int rank { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType CategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string CodeValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<RangeType> Range { get; set; }
    }
}