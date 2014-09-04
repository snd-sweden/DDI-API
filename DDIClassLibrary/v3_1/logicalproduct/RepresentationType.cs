using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class RepresentationType
    {
        public RepresentationType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public AdditivityCodeType additivity { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public AggregationMethodCodeType aggregationMethod { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string measurementUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Role { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> WeightVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType StandardWeightReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType ImputationReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ConcatenatedValueType ConcatenatedValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ReferenceType CodingInstructionsReference { get; set; }

        [System.Xml.Serialization.XmlElement("CodeRepresentation", typeof(CodeRepresentationType), Order = 6)]
        [System.Xml.Serialization.XmlElement("DateTimeRepresentation", typeof(DateTimeRepresentationType), Order = 6)]
        [System.Xml.Serialization.XmlElement("ExternalCategoryRepresentation", typeof(ExternalCategoryRepresentationType), Order = 6)]
        [System.Xml.Serialization.XmlElement("NumericRepresentation", typeof(NumericRepresentationType), Order = 6)]
        [System.Xml.Serialization.XmlElement("TextRepresentation", typeof(TextRepresentationType), Order = 6)]
        public DDIClassLibrary.v3_1.reusable.RepresentationType ValueRepresentation { get; set; }
    }
}