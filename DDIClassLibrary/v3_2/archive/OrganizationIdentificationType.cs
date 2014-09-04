using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class OrganizationIdentificationType
    {
        public OrganizationIdentificationType()
        {
            this.OrganizationName = new List<OrganizationNameType>();
            this.DDIMaintenanceAgencyID = new List<DDIMaintenanceAgencyIDType>();
            this.OrganizationImage = new List<PrivateImageType>();
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<OrganizationNameType> OrganizationName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DDIMaintenanceAgencyIDType> DDIMaintenanceAgencyID { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<PrivateImageType> OrganizationImage { get; set; }

    }
}