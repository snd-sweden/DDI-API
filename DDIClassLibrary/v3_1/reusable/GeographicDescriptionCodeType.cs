﻿namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum GeographicDescriptionCodeType
    {
        Point,
        Polygon,
        Line,
        LinearRing
    }
}