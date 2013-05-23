using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class GeographyValuesType
    {
        public GeographyValuesType()
        {
            this.GeographyValue = new List<GeographyValueType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 1)]
        public string ExternalAuthorityReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<GeographyValueType> GeographyValue { get; set; }
    }
}