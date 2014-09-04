using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class InstrumentType : VersionableType
    {
        public InstrumentType()
        {
            this.InstrumentName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ExternalInstrumentLocation = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> InstrumentName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType TypeOfInstrument { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<string> ExternalInstrumentLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public ControlConstructReferenceType ControlConstructReference { get; set; }
    }
}