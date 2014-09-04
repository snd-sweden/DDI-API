namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ParentGeographyType : ReferenceType
    {
        public ParentGeographyType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string isExhaustiveCoverage { get; set; }
    }
}