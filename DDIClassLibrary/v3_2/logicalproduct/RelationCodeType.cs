namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public enum RelationCodeType
    {
        Parent,
        Child,
        Sibling,
        Unknown
    }
}