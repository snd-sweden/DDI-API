namespace DDIClassLibrary.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class FilterCategoryStatisticType
    {
        public FilterCategoryStatisticType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public bool Weighted { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public double Value { get; set; }
    }
}