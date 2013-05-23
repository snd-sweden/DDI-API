using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class OperationType
    {
        public OperationType()
        {
            this.Description = new List<StructuredStringType>();
            this.AgencyOrganizationReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 0)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> AgencyOrganizationReference { get; set; }
    }
}