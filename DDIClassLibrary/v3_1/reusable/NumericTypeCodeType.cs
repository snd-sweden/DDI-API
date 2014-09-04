namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum NumericTypeCodeType
    {
        BigInteger,
        Integer,
        Long,
        Short,
        Decimal,
        Float,
        Double,
        Count,
        Incremental
    }
}