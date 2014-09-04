﻿namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public enum AttachmentLevelCodeType
    {
        Cube,
        CoordinateRegion,
        Dimension,
        Measurement,
        MeasurementValue
    }
}