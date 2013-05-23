namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public enum LanguageLevelCodeType
    {
        Native,
        Fluent,
        Good,
        Basic,
        Unspecified
    }
}