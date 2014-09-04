using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class NCubeSchemeType : MaintainableType
    {
        public NCubeSchemeType()
        {
            this.NCubeSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.NCube = new List<NCubeType>();
            this.NCubeReference = new List<ReferenceType>();
            this.NCubeGroup = new List<NCubeGroupType>();
            this.NCubeGroupReference = new List<ReferenceType>();
            this.NCubeSchemeReference = new List<SchemeReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> NCubeSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<NCubeType> NCube { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<ReferenceType> NCubeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<NCubeGroupType> NCubeGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ReferenceType> NCubeGroupReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<SchemeReferenceType> NCubeSchemeReference { get; set; }
    }
}