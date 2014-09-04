using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class CodeRepresentationType : DDIClassLibrary.v3_1.reusable.CodeRepresentationType
    {
        public CodeRepresentationType()
        {
            this.IncludedLevel = new List<int>();
            this.IncludedCodeReference = new List<IncludedCodeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<int> IncludedLevel { get; set; }

        public bool ShouldSerializeIncludedLevel()
        {
            return IncludedLevel.Count > 0;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<IncludedCodeReferenceType> IncludedCodeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DataExistenceType DataExistence { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public VariableConcatenationType VariableConcatenation { get; set; }
    }
}