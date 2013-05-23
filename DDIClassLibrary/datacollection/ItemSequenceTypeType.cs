namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public enum ItemSequenceTypeType
    {
        InOrderOfAppearance,
        Random,
        Rotate,
        Other
    }
}