using System;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class CodingType : IdentifiableType
    {
        public CodingType()
        {
            this.ObjectType = "Coding";
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public GeneralInstructionType GeneralInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public GenerationInstructionType GenerationInstruction { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public Nullable<float> StandardWeight { get; set; }

        public bool ShouldSerializeStandardWeight()
        {
            return StandardWeight.HasValue;
        }
    }
}