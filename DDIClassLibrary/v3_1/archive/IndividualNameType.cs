using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class IndividualNameType
    {
        public IndividualNameType()
        {
            this.Middle = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Prefix { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string First { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<string> Middle { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string Last { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string Suffix { get; set; }
    }
}