using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class CategoryStatisticType
    {
        public CategoryStatisticType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfCategoryStatistic { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StatisticType Statistic { get; set; }
    }
}