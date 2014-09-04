using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CodeSubsetInformationType
    {
        public CodeSubsetInformationType()
        {
            this.IncludedLevel = new List<int>();
        }
        
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<int> IncludedLevel { get; set; }

        public bool ShouldSerializeIncludedLevel()
        {
            return IncludedLevel.Count > 0;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public IncludedCodeType IncludedCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DataExistenceType DataExistence { get; set; }
    }
}