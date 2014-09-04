namespace DDIClassLibrary.v3_1.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public enum DataSetGroupCodeType
    {
        /// <summary>
        /// No specified relationship
        /// </summary>
        D0,

        /// <summary>
        /// Single data file from a data collection
        /// </summary>
        D1,

        /// <summary>
        /// Multiple data products from a single data collection
        /// </summary>
        D2,

        /// <summary>
        /// Integration of multiple data sets into a single integrated structure
        /// </summary>
        D3,

        /// <summary>
        /// Multiple data files each from a different data collection
        /// </summary>
        D4
    }
}