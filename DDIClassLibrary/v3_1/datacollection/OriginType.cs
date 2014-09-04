using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class OriginType
    {
        public OriginType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 1)]
        public string OriginLocation { get; set; }
    }
}