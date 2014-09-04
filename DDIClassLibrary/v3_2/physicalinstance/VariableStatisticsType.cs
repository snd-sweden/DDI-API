using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class VariableStatisticsType : VersionableType 
    {
        public VariableStatisticsType()
        {
            this.SummaryStatistic = new List<SummaryStatisticType>();
            this.UnfilteredCategoryStatistics = new List<UnfilteredCategoryStatisticsType>();
            this.FilteredCategoryStatistics = new List<FilteredCategoryStatisticsType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<int> TotalResponses { get; set; }

        public bool ShouldSerializeTotalResponses()
        {
            return TotalResponses.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType StandardWeightReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ReferenceType WeightVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType MissingValuesReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<SummaryStatisticType> SummaryStatistic { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<UnfilteredCategoryStatisticsType> UnfilteredCategoryStatistics { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<FilteredCategoryStatisticsType> FilteredCategoryStatistics { get; set; }
    }
}