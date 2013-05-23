namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public enum GeographyGroupCodeType
    {
        /// <summary>
        /// No specified relationship
        /// </summary>
        G0,

        /// <summary>
        /// Single geography surveyed multiple times
        /// </summary>
        G1,

        /// <summary>
        /// Single geography surveyed once
        /// </summary>
        G2,

        /// <summary>
        /// Rolling geography
        /// </summary>
        G3,

        /// <summary>
        /// Different geography each survey
        /// </summary>
        G4
    }
}