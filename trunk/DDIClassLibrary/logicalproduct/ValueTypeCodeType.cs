namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public enum ValueTypeCodeType
    {
        GreaterThan,
        LessThan,
        Equal,
        GreaterThanOrEqual,
        LessThanOrEqual,
        NotEqual
    }
}