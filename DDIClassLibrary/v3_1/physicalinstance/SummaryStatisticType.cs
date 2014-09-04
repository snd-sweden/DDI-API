using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class SummaryStatisticType
    {
        public SummaryStatisticType()
        {
            this.Weighted = false;
        }

        [System.Xml.Serialization.XmlElement("SummaryStatisticType", typeof(CodeValueType), Order = 0)]
        [System.Xml.Serialization.XmlElement("SummaryStatisticTypeCoded", typeof(SummaryStatisticTypeCodedType), Order = 0)]
        public CodeValueType TypeOfSummaryStatistic { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public bool Weighted { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public double Value { get; set; }
    }
}