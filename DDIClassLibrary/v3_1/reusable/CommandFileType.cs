using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CommandFileType
    {
        public CommandFileType()
        {
            this.Location = new List<string>();
            this.Path = new List<string>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string formalLanguage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<string> Location { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<string> Path { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2, DataType = "anyURI")]
        public List<string> URI { get; set; }
    }
}