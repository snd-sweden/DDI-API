using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class RelationType
    {
        public RelationType()
        {
            this.OrganizationReference = new List<ReferenceType>();
            this.IndividualReference = new List<ReferenceType>();
            this.Description = new List<StructuredStringType>();
            this.Keyword = new List<InternationalStringType>();
            this.Period = new List<DateType>();
            this.Note = new List<string>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> OrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> IndividualReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = false, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<InternationalStringType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<DateType> Period { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<string> Note { get; set; }
    }
}