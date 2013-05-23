using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class VariableConcatenationType
    {
        public VariableConcatenationType()
        {
            this.ConcatenatedValue = new List<ConcatenatedValueType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<ConcatenatedValueType> ConcatenatedValue { get; set; }
    }
}