namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public enum TimeGroupCodeType
    {
        /// <summary>
        /// No specified relationship
        /// </summary>
        T0,

        /// <summary>
        /// Single Occurrence
        /// </summary>
        T1,

        /// <summary>
        /// Multiple Occurrence: Regular Occurrence: Continuing
        /// </summary>
        T2,

        /// <summary>
        /// Multiple Occurrence: Regular Occurrence: Limited time
        /// </summary>
        T3,

        /// <summary>
        /// Multiple Occurrence: Irregular Occurrence: Continuing
        /// </summary>
        T4,

        /// <summary>
        /// Multiple Occurrence: Irregular Occurrence: Limited time
        /// </summary>
        T5
    }
}