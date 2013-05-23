namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public enum AggregationMethodCodeType
    {
        Sum,
        Average,
        Count,
        Mode,
        Median,
        Maximum,
        Minimum,
        Percent,
        CumulativePercent,
        PercentileRank
    }
}