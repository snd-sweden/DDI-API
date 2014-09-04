namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public enum PanelGroupCodeType
    {
        /// <summary>
        /// No specified relationship
        /// </summary>
        P0,

        /// <summary>
        /// Single panel surveyed multiple times
        /// </summary>
        P1,

        /// <summary>
        /// Single panel surveyed once
        /// </summary>
        P2,

        /// <summary>
        /// Rolling panel
        /// </summary>
        P3,

        /// <summary>
        /// Different panel each survey
        /// </summary>
        P4
    }
}