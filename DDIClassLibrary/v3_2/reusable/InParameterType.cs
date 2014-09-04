using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class InParameterType : ParameterType
    {
        public InParameterType()
        {

        }

        [System.Xml.Serialization.XmlAttribute()]
        public string limitArrayIndex { get; set; }

    }
}
