using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class SoftwareType : IdentifiableType
    {
        public SoftwareType()
        {
            this.ObjectType = "Software";

            this.Name = new List<InternationalStringType>();
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalStringType> Name { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType SoftwarePackage { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Version { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public DateType Date { get; set; }
    }
}