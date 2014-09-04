using System.Collections.Generic;
using System.Runtime.Serialization;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.conceptualcomponent
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:conceptualcomponent:3_1")]
    public class UniverseSchemeType : MaintainableType
    {
        public UniverseSchemeType()
        {
            this.ObjectType = "UniverseScheme";

            this.UniverseSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.UniverseSchemeReference = new List<ReferenceType>();
            this.Universe = new List<UniverseType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> UniverseSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> UniverseSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public VocabularyType Vocabulary { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<UniverseType> Universe { get; set; }

    }
}