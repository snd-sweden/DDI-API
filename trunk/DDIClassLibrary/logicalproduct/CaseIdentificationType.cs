using System.Collections.Generic;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CaseIdentificationType
    {
        public CaseIdentificationType()
        {
            this.VariableSpecificationReference = new List<VariableSpecificationReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<VariableSpecificationReferenceType> VariableSpecificationReference { get; set; }
    }
}