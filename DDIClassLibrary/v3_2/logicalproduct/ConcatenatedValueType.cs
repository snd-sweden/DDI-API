using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class ConcatenatedValueType
    {
        public ConcatenatedValueType()
        {
            this.VariableReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 0)]
        public List<ReferenceType> VariableReference { get; set; }
    }
}