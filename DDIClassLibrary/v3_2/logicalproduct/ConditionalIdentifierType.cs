using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class ConditionalIdentifierType
    {
        public ConditionalIdentifierType()
        {
            this.CaseSpecification = new List<CaseSpecificationType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<CaseSpecificationType> CaseSpecification { get; set; }
    }
}