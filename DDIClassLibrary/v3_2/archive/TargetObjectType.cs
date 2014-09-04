using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class TargetObjectType
    {
        public TargetObjectType()
        {
            this.Role = new List<RoleType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType OrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType IndividualReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<RoleType> Role { get; set; }

    }
}