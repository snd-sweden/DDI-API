using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class DataFileIdentificationType : IdentifiableType
    {
        public DataFileIdentificationType()
        {
            this.ObjectType = "DataFileIdentification";

            this.Location = new List<string>();
            this.Path = new List<PathType>();
            this.URI = new List<URIType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<string> Location { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<PathType> Path { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<URIType> URI { get; set; }
    }
}