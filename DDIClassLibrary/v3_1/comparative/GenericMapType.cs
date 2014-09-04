using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_1")]
    public class GenericMapType : VersionableType
    {
        public GenericMapType()
        {
            this.ObjectType = "GenericMap";

            this.MapName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.ItemMap = new List<ItemMapType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> MapName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType SourceSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public ReferenceType TargetSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CorrespondenceType Correspondence { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ItemMapType> ItemMap { get; set; }
    }
}