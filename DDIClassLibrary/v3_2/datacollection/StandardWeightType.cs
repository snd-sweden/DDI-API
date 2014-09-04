using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class StandardWeightType : IdentifiableType
    {
        public StandardWeightType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public Nullable<float> StandardWeightValue { get; set; }

        public bool ShouldSerializeStandardWeightValue() 
        {
            return StandardWeightValue.HasValue;
        }
    }
}