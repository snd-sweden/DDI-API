using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class HistoricalDateType
    {
        public HistoricalDateType()
        {
        }
        
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string NONISODate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType HistoricalDateFormat { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType Calendar { get; set; }

    }
}