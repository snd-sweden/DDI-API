using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public abstract class AbstractVersionableType : AbstractIdentifiableType
    {
        public AbstractVersionableType()
        {
            this.UserAttributePair = new List<StandardKeyValuePairType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string versionDate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<StandardKeyValuePairType> UserAttributePair { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string VersionResponsibility { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType VersionResponsibilityReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public VersionRationaleType VersionRationale { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public BasedOnObjectType BasedOnObject { get; set; }
    }
}