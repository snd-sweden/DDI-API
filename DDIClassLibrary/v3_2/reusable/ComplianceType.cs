using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ComplianceType
    {
        public ComplianceType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType ComplianceConceptReference { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType ExternalComplianceCode { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ComplianceType> Compliance { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType ComplianceDescription { get; set; }
    }
}