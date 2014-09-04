using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class VariableSpecificationReferenceType
    {
        public VariableSpecificationReferenceType()
        {
            this.CaseSpecification = new List<CaseSpecificationType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CaseSpecificationType> CaseSpecification { get; set; }
    }
}