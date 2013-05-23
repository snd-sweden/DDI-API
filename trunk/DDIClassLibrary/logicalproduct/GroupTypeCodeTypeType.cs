namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public enum GroupTypeCodeTypeType
    {
        Section,
        MultipleResponse,
        Grid,
        Display,
        Repetition,
        Subject,
        Version,
        Iteration,
        Analysis,
        Pragmatic,
        Record,
        File,
        Randomized,
        UseOther
    }
}