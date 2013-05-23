using DDIClassLibrary.reusable;

namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class DataCollectionType
    {
        public DataCollectionType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", Order = 0)]
        public DDIClassLibrary.datacollection.DataCollectionType DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}