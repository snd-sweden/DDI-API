using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class DataExistenceType
    {
        public DataExistenceType()
        {
            this.Level = new List<int>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<int> Level { get; set; }

        public bool ShouldSerializeLevel()
        {
            return Level.Count > 0;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public bool DiscreteCategory { get; set; }
    }
}