using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class AuthorizedSourceType : OtherMaterialType
    {
        public AuthorizedSourceType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IdentifierParsingInformationType IdentifierParsingInformation { get; set; }
    }
}