using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class KeyVariableReferenceType : ReferenceType
    {
        public KeyVariableReferenceType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string VariableValue { get; set; }
    }
}