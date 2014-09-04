using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class FilterCategoryStatisticsType
    {
        public FilterCategoryStatisticsType()
        {
            this.FilterCategoryStatistic = new List<FilterCategoryStatisticType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string FilterCategoryValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<FilterCategoryStatisticType> FilterCategoryStatistic { get; set; }
    }
}