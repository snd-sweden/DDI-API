using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class StudyUnitType
    {
        public StudyUnitType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:studyunit:3_1", Order = 0)]
        public DDIClassLibrary.v3_1.studyunit.StudyUnitType StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}