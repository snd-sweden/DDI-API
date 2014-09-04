using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DateType
    {
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string SimpleDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public HistoricalDateType HistoricalDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string StartDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public HistoricalDateType HistoricalStartDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string EndDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public HistoricalDateType HistoricalEndDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public Nullable<int> Cycle { get; set; }

        public bool ShouldSerializeCycle()
        {
            return Cycle.HasValue;
        }
    }
}