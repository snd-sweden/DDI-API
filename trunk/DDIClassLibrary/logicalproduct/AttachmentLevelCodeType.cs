namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public enum AttachmentLevelCodeType
    {
        /// <summary>
        /// Attaches to the whole NCube.
        /// </summary>
        Cube,

        /// <summary>
        /// Attaches to a group of dimensions (given particular values) described by a coordinate group.
        /// </summary>
        CoordinateGroup,

        /// <summary>
        /// Attaches to a dimension only.
        /// </summary>
        Dimension,

        /// <summary>
        /// Attaches to a specific measurement.
        /// </summary>
        Measurement,

        /// <summary>
        /// Attaches to a specific measurement value.
        /// </summary>
        MeasurementValue
    }
}