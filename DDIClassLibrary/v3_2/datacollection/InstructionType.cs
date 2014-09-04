using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class InstructionType : VersionableType
    {
        public InstructionType()
        {
            this.InstructionName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.InParameter = new List<InParameterType>();
            this.AssociatedImage = new List<ImageType>();
            this.InstructionText = new List<DynamicTextType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> InstructionName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<InParameterType> InParameter { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ImageType> AssociatedImage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<DynamicTextType> InstructionText { get; set; }
    }
}