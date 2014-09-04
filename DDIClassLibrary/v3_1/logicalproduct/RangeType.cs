using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class RangeType
    {
        public RangeType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string RangeUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 1)]
        public RangeValueType MinimumValue { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 2)]
        public RangeValueType MaximumValue { get; set; }
    }
}