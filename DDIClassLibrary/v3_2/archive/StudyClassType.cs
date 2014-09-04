using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class StudyClassType
    {
        public StudyClassType()
        {

        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType ClassType { get; set; }
    }
}