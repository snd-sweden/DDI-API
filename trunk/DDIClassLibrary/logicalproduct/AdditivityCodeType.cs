﻿namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public enum AdditivityCodeType
    {
        Stock,
        Flow,
        NonAdditive
    }
}