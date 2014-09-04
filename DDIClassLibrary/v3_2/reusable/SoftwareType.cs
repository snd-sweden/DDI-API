using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class SoftwareType
    {
        public SoftwareType()
        {
            this.SoftwareName = new List<NameType>();
            this.Function = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> SoftwareName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType SoftwarePackage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string SoftwareVersion { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public DateType Date { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<CodeValueType> Function { get; set; }
    }
}