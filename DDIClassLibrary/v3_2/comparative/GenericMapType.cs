using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_2")]
    public class GenericMapType : VersionableType
    {
        public GenericMapType()
        {
            this.MapName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ItemMap = new List<ItemMapType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> MapName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public SchemeReferenceType SourceSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public SchemeReferenceType TargetSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CorrespondenceType Correspondence { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ItemMapType> ItemMap { get; set; }
    }
}