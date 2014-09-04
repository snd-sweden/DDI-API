using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class InstrumentType : MaintainableType
    {
        public InstrumentType()
        {
            this.ObjectType = "Instrument";

            this.InstrumentName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.Description = new List<StructuredStringType>();
            this.Software = new List<SoftwareType>();
            this.ExternalInstrumentLocation = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> InstrumentName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 2)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CodeValueType Type { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<SoftwareType> Software { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", IsNullable = true, Order = 5)]
        public List<string> ExternalInstrumentLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public ReferenceType ControlConstructReference { get; set; }
    }
}