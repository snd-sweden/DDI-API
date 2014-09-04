using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CommandType
    {
        public CommandType()
        {
            this.InParameter = new List<InParameterType>();
            this.OutParameter = new List<ParameterType>();
            this.Binding = new List<BindingType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType ProgramLanguage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InParameterType> InParameter { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ParameterType> OutParameter { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<BindingType> Binding { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string CommandContent { get; set; }
    }
}
