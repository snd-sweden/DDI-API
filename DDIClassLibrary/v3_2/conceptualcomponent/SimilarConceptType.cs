using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_2")]
    public class SimilarConceptType
    {
        public SimilarConceptType()
        {
  
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType SimilarConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Difference { get; set; }
    }
}