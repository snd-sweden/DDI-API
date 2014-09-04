using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class DateType
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string calendar { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string SimpleDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string StartDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public HistoricalDateType HistoricalStartDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string EndDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public HistoricalDateType HistoricalEndDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public Nullable<int> Cycle { get; set; }

        public bool ShouldSerializeCycle()
        {
            return Cycle.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public HistoricalDateType HistoricalDate { get; set; }
    }
}