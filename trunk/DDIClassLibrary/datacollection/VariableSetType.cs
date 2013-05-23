using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class VariableSetType : IdentifiableType
    {
        public VariableSetType()
        {
            this.ObjectType = "VariableSet";

            this.IndependentVariableReference = new List<ReferenceType>();
            this.DependentVariableReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> IndependentVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<ReferenceType> DependentVariableReference { get; set; }
    }
}