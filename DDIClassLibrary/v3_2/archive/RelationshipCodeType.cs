namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public enum RelationshipCodeType
    {
        Parent,
        Child,
        Sibling
    }
}