using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class UnfilteredCategoryStatisticsType {
    
        public UnfilteredCategoryStatisticsType()
        {
            this.VariableCategory = new List<VariableCategoryType> ();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<VariableCategoryType> VariableCategory { get; set; }
    }
}