namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum VideoClipTypeCodedType
    {
        @byte,
        smil,
        midi,
        smpte_25,
        smpte_24,
        smpte_df30,
        smpte_ndf30,
        smpte_df29_97,
        smpte_ndf29_97,
        time,
        tcf,
        other
    }
}