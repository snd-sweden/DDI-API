using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class SourceObjectType
    {
        public SourceObjectType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType OrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType IndividualReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public RelationshipCodeType RelationshipCode { get; set; }

    }
}