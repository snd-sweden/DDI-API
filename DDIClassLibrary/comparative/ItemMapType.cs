namespace DDIClassLibrary.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_1")]
    public class ItemMapType
    {
        public ItemMapType()
        {
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "NCName")]
        public string alias { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "NCName", Order = 0)]
        public string SourceItem { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "NCName", Order = 1)]
        public string TargetItem { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CorrespondenceType Correspondence { get; set; }
    }
}