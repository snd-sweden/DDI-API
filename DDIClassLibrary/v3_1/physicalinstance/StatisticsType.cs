using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class StatisticsType
    {
        public StatisticsType()
        {
            this.StatisticalDataFileReference = new List<StatisticalDataFileReferenceType>();
            this.VariableStatistics = new List<VariableStatisticsType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<StatisticalDataFileReferenceType> StatisticalDataFileReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<VariableStatisticsType> VariableStatistics { get; set; }
    }
}