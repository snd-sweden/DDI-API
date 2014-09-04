using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public abstract class AbstractMaintainableType : AbstractVersionableType
    {
        public AbstractMaintainableType()
        {
            this.Note = new List<NoteType>();
            this.Software = new List<SoftwareType>();
            this.MetadataQuality = new List<MetadataQualityType>();
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string externalReferenceDefaultURI { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPublished { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<SoftwareType> Software { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<MetadataQualityType> MetadataQuality { get; set; }
    }
}