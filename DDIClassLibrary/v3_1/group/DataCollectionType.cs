using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class DataCollectionType
    {
        public DataCollectionType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", Order = 0)]
        public DDIClassLibrary.v3_1.datacollection.DataCollectionType DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType Reference { get; set; }
    }
}