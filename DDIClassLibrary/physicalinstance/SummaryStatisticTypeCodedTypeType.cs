namespace DDIClassLibrary.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public enum SummaryStatisticTypeCodedTypeType
    {
        Mean,
        Mode,
        Median,
        ValidCases,
        InvalidCases,
        Minimum,
        Maximum,
        StandardDeviation,
        FirstQuartile,
        ThirdQuartile,
        FirstQuintile,
        SecondQuintile,
        ThirdQuintile,
        FourthQuintile,
        FirstDecile,
        SecondDecile,
        ThirdDecile,
        FourthDecile,
        FifthDecile,
        SixthDecile,
        SeventhDecile,
        EightDecile,
        NinthDecile,
        UseOther
    }
}