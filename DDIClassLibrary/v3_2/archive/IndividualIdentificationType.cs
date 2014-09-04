using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class IndividualIdentificationType
    {
        public IndividualIdentificationType()
        {
            this.IndividualName = new List<IndividualNameType>();
            this.DDIMaintenanceAgencyID = new List<DDIMaintenanceAgencyIDType>();
            this.ResearcherID = new List<ResearcherIDType>();
            this.IndividualImageType = new List<PrivateImageType>();
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<IndividualNameType> IndividualName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DDIMaintenanceAgencyIDType> DDIMaintenanceAgencyID { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ResearcherIDType> ResearcherID { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<PrivateImageType> IndividualImageType { get; set; }

    }
}