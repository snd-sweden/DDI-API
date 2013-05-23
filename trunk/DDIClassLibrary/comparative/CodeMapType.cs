using System.Collections.Generic;
using DDIClassLibrary.datacollection;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.comparative
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:comparative:3_1")]
    public class CodeMapType : VersionableType
    {
        public CodeMapType()
        {
            this.ObjectType = "CodeMap";

            this.CodeMapName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.GenerationInstruction = new List<GenerationInstructionType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> CodeMapName { get; set; }

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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", IsNullable = true, Order = 6)]
        public List<GenerationInstructionType> GenerationInstruction { get; set; }
    }
}