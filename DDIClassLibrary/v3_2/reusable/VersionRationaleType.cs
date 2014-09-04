using System;
namespace DDIClassLibrary.v3_2.reusable
{
    public class VersionRationaleType
    {

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public System.Collections.Generic.List<CodeValueType> RationaleCode { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public System.Collections.Generic.List<InternationalStringType> RationaleDescription { get; set; }
    }
}