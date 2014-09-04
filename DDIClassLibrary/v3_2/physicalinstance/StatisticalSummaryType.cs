using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class StatisticalSummaryType
    {
        public StatisticalSummaryType()
        {
            this.StatisticalDataFileReference = new List<StatisticalDataLocationType>();
            this.VariableStatistics = new List<VariableStatisticsType>();
            this.VariableStatisticsReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<StatisticalDataLocationType> StatisticalDataFileReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<VariableStatisticsType> VariableStatistics { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ReferenceType> VariableStatisticsReference { get; set; }
    }
}