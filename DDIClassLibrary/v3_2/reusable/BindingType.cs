namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class BindingType
    {
        public BindingType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType SourceParameterReference { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType TargetParameterReference { get; set; }
    }
}