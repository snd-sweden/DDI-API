using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class DefaultMissingValuesType
    {
        public DefaultMissingValuesType()
        {
            this.MissingValuesReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> MissingValuesReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<bool> DefaultUsedNoDocumentation { get; set; }

        public bool ShouldSerializeDefaultUsedNoDocumentation()
        {
            return DefaultUsedNoDocumentation.HasValue;
        }
    }
}