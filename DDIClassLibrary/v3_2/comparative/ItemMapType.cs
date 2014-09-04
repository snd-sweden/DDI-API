using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_2")]
    public class ItemMapType : IdentifiableType
    {
        public ItemMapType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string alias { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public IDType SourceItem { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public IDType TargetItem { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CorrespondenceType Correspondence { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<ReferenceType> RelatedMapReference { get; set; }
    }
}