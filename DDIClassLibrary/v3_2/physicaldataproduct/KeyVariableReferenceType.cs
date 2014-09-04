using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class KeyVariableReferenceType : ReferenceType
    {
        public KeyVariableReferenceType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ValueType Value { get; set; }
    }
}