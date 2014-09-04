using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CommandCodeType
    {
        public CommandCodeType()
        {
            this.Command = new List<CommandType>();
            this.CommandFile = new List<CommandFileType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CommandType> Command { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<CommandFileType> CommandFile { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredCommandType StructuredCommand { get; set; }
    }
}
