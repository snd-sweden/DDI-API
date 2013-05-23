using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class ConceptReferenceType : ReferenceType
    {
        public ConceptReferenceType()
        {
            this.ConceptReference = new List<ConceptReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ConceptReferenceType> ConceptReference { get; set; }
    }
}