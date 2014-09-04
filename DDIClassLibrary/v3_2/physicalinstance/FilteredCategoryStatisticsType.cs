using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class FilteredCategoryStatisticsType
    {
        public FilteredCategoryStatisticsType()
        {
            this.FilterVariableCategory = new List<FilterVariableCategoryType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType FilterVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<FilterVariableCategoryType> FilterVariableCategory { get; set; }
    }
}