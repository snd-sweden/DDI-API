using System.Collections.Generic;
using DDIClassLibrary.dcelements;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CitationType
    {
        public CitationType()
        {
            this.Title = new List<InternationalStringType>();
            this.SubTitle = new List<InternationalStringType>();
            this.AlternativeType = new List<InternationalStringType>();
            this.Creator = new List<CreatorType>();
            this.Publisher = new List<InternationalStringType>();
            this.Contributor = new List<ContributorType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<InternationalStringType> Title { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InternationalStringType> SubTitle { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> AlternativeType { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<CreatorType> Creator { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<InternationalStringType> Publisher { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ContributorType> Contributor { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public DateType PublicationDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public string Language { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<TypedStringType> InternationalIdentifier { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public InternationalStringType Copyright { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 10, Namespace = "ddi:dcelements:3_1")]
        public DCElementsType DCElements { get; set; }
    }
}