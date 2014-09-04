using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ParameterType : IdentifiableType
    {
        public ParameterType()
        {

        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ParameterName { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Alias { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement("CodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.CodeRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("DateTimeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.DateTimeRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("ExternalCategoryRepresentation", typeof(DDIClassLibrary.v3_2.reusable.ExternalCategoryRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("GeographicLocationCodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.GeographicLocationCodeRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("GeographicStructureCodeRepresentation", typeof(DDIClassLibrary.v3_2.reusable.GeographicStructureCodeRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("NumericRepresentation", typeof(DDIClassLibrary.v3_2.reusable.NumericRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("ScaleRepresentation", typeof(DDIClassLibrary.v3_2.reusable.ScaleRepresentationBaseType), IsNullable = true, Order = 3)]
        [System.Xml.Serialization.XmlElement("TextRepresentation", typeof(DDIClassLibrary.v3_2.reusable.TextRepresentationBaseType), IsNullable = true, Order = 3)]
        public RepresentationType ValueRepresentation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public RepresentationReferenceType DateTimeRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public RepresentationReferenceType NumericRepresentationReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public RepresentationReferenceType ScaleRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public RepresentationReferenceType TextRepresentationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public ValueType DefaultValue { get; set; }
    }
}
