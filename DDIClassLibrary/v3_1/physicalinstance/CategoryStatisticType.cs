using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class CategoryStatisticType
    {
        public CategoryStatisticType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfCategoryStatistic { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public bool Weighted { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public double Value { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public FilterType Filter { get; set; }
    }
}