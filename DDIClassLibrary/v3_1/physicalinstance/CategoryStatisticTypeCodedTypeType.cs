namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public enum CategoryStatisticTypeCodedTypeType
    {
        Frequency,
        Percent,
        CrossTabulation,
        ValidCases,
        InvalidCases,
        Minimum,
        Maximum,
        StandardDeviation,
        CumulativePercent,
        UseOther
    }
}