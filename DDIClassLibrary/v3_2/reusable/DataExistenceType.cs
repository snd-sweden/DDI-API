using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DataExistenceType
    {
        public DataExistenceType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public Nullable<int> LevelNumber { get; set; }

        public bool ShouldSerializeLevelNumber()
        {
            return LevelNumber.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public Nullable<bool> DiscreteCategory { get; set; }

        public bool ShouldSerializeDiscreteCategory()
        {
            return DiscreteCategory.HasValue;
        }
    }
}