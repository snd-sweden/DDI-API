﻿namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum PointFormatType
    {
        DecimalDegree,
        DegreeesMinutesSeconds,
        DecimalMinutes,
        Meters,
        Feet
    }
}