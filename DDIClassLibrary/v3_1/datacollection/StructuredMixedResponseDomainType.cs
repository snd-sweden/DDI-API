using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class StructuredMixedResponseDomainType
    {
        public StructuredMixedResponseDomainType()
        {
            this.ResponseText = new List<DynamicTextType>();
            this.ResponseDomain = new RepresentationType();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<DynamicTextType> ResponseText { get; set; }

        [System.Xml.Serialization.XmlElement("CategoryDomain", typeof(CategoryDomainType), IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlElement("CodeDomain", typeof(CodeDomainType), IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlElement("DateTimeDomain", typeof(DateTimeDomainType), IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlElement("GeographicDomain", typeof(GeographicDomainType), IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlElement("NumericDomain", typeof(NumericDomainType), IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlElement("ResponseDomain", typeof(RepresentationType), IsNullable = true, Order = 1)]
        [System.Xml.Serialization.XmlElement("TextDomain", typeof(TextDomainType), IsNullable = true, Order = 1)]
        public RepresentationType ResponseDomain { get; set; }
    }
}