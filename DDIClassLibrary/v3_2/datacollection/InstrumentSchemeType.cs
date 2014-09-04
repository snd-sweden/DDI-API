using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class InstrumentSchemeType : MaintainableType
    {
        public InstrumentSchemeType()
        {
            this.InstrumentSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.InstrumentSchemeReference = new List<SchemeReferenceType>();
            this.Instrument = new List<InstrumentType>();
            this.InstrumentReference= new List<ReferenceType>();
            this.InstrumentGroup = new List<InstrumentGroupType>();
            this.InstrumentGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> InstrumentSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> InstrumentSchemeReference { get; set; }
        
       [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<InstrumentType> Instrument { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
       public List<ReferenceType> InstrumentReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<InstrumentGroupType> InstrumentGroup { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> InstrumentGroupReference { get; set; }
    }
}