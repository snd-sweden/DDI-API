using System.Collections.Generic;

namespace DDIClassLibrary.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class CategoryStatisticsType
    {
        public CategoryStatisticsType()
        {
            this.CategoryStatistic = new List<CategoryStatisticType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string CategoryValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<CategoryStatisticType> CategoryStatistic { get; set; }
    }
}