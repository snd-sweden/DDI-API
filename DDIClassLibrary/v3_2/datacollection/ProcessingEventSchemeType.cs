using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class ProcessingEventSchemeType : MaintainableType
    {
        public ProcessingEventSchemeType()
        {
            this.ProcessingEventSchemeName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.ProcessingEventSchemeReference = new List<SchemeReferenceType>();
            this.ProcessingEvent = new List<ProcessingEventType>();
            this.ProcessingEventReference = new List<ReferenceType>();
            this.ProcessingEventGroup = new List<ProcessingEventGroupType>();
            this.ProcessingEventGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> ProcessingEventSchemeName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<SchemeReferenceType> ProcessingEventSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ProcessingEventType> ProcessingEvent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> ProcessingEventReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<ProcessingEventGroupType> ProcessingEventGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ReferenceType> ProcessingEventGroupReference { get; set; }
    }
}