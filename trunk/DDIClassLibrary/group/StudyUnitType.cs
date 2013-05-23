using DDIClassLibrary.reusable;

namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class StudyUnitType
    {
        public StudyUnitType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:studyunit:3_1", Order = 0)]
        public DDIClassLibrary.studyunit.StudyUnitType StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}