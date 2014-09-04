namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public enum ItemSequenceTypeType
    {
        InOrderOfAppearance,
        Random,
        Rotate,
        Other
    }
}