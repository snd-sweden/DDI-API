using DDIClassLibrary.reusable;

namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class ResearcherIDType
    {
        public ResearcherIDType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType Type { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Identifier { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 2)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 3)]
        public StructuredStringType Description { get; set; }
    }
}