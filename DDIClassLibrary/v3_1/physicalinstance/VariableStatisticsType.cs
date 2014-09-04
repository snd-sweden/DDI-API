using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class VariableStatisticsType
    {
        public VariableStatisticsType()
        {
            this.ExcludedMissingCategoryReference = new List<ReferenceType>();
            this.SummaryStatistic = new List<SummaryStatisticType>();
            this.CategoryStatistics = new List<CategoryStatisticsType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<int> TotalResponses { get; set; }

        public bool ShouldSerializeTotalResponses()
        {
            return TotalResponses.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType WeightUsedReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType WeightVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ReferenceType> ExcludedMissingCategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<SummaryStatisticType> SummaryStatistic { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<CategoryStatisticsType> CategoryStatistics { get; set; }
    }
}