using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class ConcatenatedValueType
    {
        public ConcatenatedValueType()
        {
            this.VariableReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> VariableReference { get; set; }
    }
}