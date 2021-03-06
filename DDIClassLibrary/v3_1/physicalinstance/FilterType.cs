﻿using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class FilterType
    {
        public FilterType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType FilterVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public FilterCategoryStatisticsType FilterCategoryStatistics { get; set; }
    }
}