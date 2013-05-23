using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class LevelReferenceType
    {
        public LevelReferenceType()
        {
            this.LevelReference = new List<ReferenceType>();
            this.LevelName = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> LevelReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<string> LevelName { get; set; }
    }
}