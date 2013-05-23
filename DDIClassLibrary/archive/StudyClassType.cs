using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class StudyClassType
    {
        public StudyClassType()
        {
            this.ClassDescription = new List<InternationalStringType>();
            this.ClassType = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<InternationalStringType> ClassDescription { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CodeValueType> ClassType { get; set; }
    }
}