using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class AggregationVariablesType : IdentifiableType
    {
        public AggregationVariablesType()
        {
            this.IndependentVariableReference = new List<ReferenceType>();
            this.DependentVariableReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> IndependentVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<ReferenceType> DependentVariableReference { get; set; }
    }
}