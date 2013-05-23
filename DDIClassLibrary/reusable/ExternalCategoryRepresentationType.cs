using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ExternalCategoryRepresentationType : RepresentationType
    {
        public ExternalCategoryRepresentationType()
        {
            this.Description = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 0)]
        public string ExternalCategoryReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<StructuredStringType> Description { get; set; }
    }
}