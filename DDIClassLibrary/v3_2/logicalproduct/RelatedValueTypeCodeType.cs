﻿namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public enum RelatedValueTypeCodeType
    {
        GreaterThan,
        LessThan,
        Equal,
        GreaterThanOrEqual,
        LessThanOrEqual,
        NotEqual
    }
}