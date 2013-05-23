using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class TextualType
    {
        public TextualType()
        {
            this.LineParameter = new List<LineParameterType>();
            this.CharacterParamenter = new List<CharacterParameterType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<LineParameterType> LineParameter { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CharacterParameterType> CharacterParamenter { get; set; }
    }
}