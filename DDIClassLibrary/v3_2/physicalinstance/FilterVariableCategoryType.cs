using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class FilterVariableCategoryType
    {
        public FilterVariableCategoryType()
        {
            this.VariableCategory = new List<VariableCategoryType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string FilterCategoryValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<VariableCategoryType> VariableCategory { get; set; }
    }
}