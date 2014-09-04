namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum NoteTypeCodeType
    {
        Processing,
        Footnote,
        Addendum,
        System,
        Problem,
        Comment,
        Other
    }
}