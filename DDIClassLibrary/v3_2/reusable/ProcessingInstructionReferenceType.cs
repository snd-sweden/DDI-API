using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ProcessingInstructionReferenceType : ReferenceType
    {
        public ProcessingInstructionReferenceType()
        {
            this.Binding = new List<BindingType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<BindingType> Binding { get; set; }
    }
}