using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class LogicalRecordType : IdentifiableType
    {
        public LogicalRecordType()
        {
            this.ObjectType = "LogicalRecord";

            this.LogicalRecordName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.CaseIdentification = new List<CaseIdentificationType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> LogicalRecordName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public VariableValueReferenceType VariableValueReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public VariableValueReferenceType SupportForMultipleSegments { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<CaseIdentificationType> CaseIdentification { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public VariablesInRecordType VariablesInRecord { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public NCubesInRecordType NCubesInRecord { get; set; }
    }
}