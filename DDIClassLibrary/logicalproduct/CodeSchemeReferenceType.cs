using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CodeSchemeReferenceType : ReferenceType
    {
        public CodeSchemeReferenceType()
        {
            this.IncludedLevel = new List<int>();
            this.IncludedCodeReference = new List<IncludedCodeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<int> IncludedLevel { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<IncludedCodeReferenceType> IncludedCodeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DataExistenceType DataExistence { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public VariableConcatenationType VariableConcatenation { get; set; }
    }
}