namespace DDIClassLibrary.v3_1.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_1")]
    public class UserDefinedCorrespondencePropertyType
    {
        public UserDefinedCorrespondencePropertyType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Value { get; set; }
    }
}