using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class SimilarConceptType
    {
        public SimilarConceptType()
        {
            this.Difference = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType SimilarConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> Difference { get; set; }
    }
}