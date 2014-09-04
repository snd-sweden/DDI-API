namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class DateTimeRepresentationType : RepresentationType
    {
        public DateTimeRepresentationType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public DateTypeCodeType type { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string format { get; set; }
    }
}