namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ActionType
    {
        public ActionType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string regExp { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public SegmentType RegionOfAction { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public StructuredStringType Description { get; set; }


    }
}