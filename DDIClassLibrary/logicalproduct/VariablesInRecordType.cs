using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class VariablesInRecordType
    {
        public VariablesInRecordType()
        {
            this.VariableSchemeReference = new List<SchemeReferenceType>();
            this.VariableUsedReference = new List<VariableUsedReferenceType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public bool allVariablesInLogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<SchemeReferenceType> VariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<VariableUsedReferenceType> VariableUsedReference { get; set; }
    }
}