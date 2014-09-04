using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class VariableCategoryType
    {
        public VariableCategoryType()
        {
            this.CategoryStatistic = new List<CategoryStatisticType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CategoryValueType CategoryValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<CategoryStatisticType> CategoryStatistic { get; set; }
    }
}