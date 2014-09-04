using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class SummaryStatisticType
    {
        public SummaryStatisticType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfSummaryStatistic { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StatisticType Statistic { get; set; }

    }
}