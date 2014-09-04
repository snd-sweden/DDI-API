namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CategoryRepresentationType : RepresentationType
    {
        public CategoryRepresentationType()
        {
            this.CategorySchemeReference = new ReferenceType();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType CategorySchemeReference { get; set; }
    }
}