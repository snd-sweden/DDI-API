using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CommandType
    {
        public CommandType()
        {
            this.CommandFile = new List<CommandFileType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string formalLanguage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string CommandText { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CommandFileType> CommandFile { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredCommandType StructuredCommand { get; set; }
    }
}