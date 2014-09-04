namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public enum InstrumentGroupCodeType
    {
        /// <summary>
        /// No specified relationship
        /// </summary>
        I0,

        /// <summary>
        /// Single
        /// </summary>
        I1,

        /// <summary>
        /// Multiple: Integrated set of 2 or more instruments used for different subpopulations
        /// </summary>
        I2,

        /// <summary>
        /// Multiple: Base with Topical changes
        /// </summary>
        I3
    }
}