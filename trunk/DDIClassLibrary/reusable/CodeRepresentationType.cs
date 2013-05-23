namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CodeRepresentationType : RepresentationType
    {
        public CodeRepresentationType()
        {
            this.CodeSchemeReference = new ReferenceType();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType CodeSchemeReference { get; set; }
    }
}