using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.dcelements
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:dcelements:3_1")]
    public class DCElementsType
    {
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<elementType> title { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<elementType> creator { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<elementType> subject { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<elementType> description { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<elementType> publisher { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<elementType> contributor { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<elementType> date { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<elementType> type { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<elementType> format { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<elementType> identifier { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<elementType> source { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<elementType> language { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<elementType> relation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<elementType> coverage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<elementType> rights { get; set; }

        public DCElementsType()
        {
            title = new List<elementType>();
            creator = new List<elementType>();
            subject = new List<elementType>();
            description = new List<elementType>();
            publisher = new List<elementType>();
            contributor = new List<elementType>();
            date = new List<elementType>();
            type = new List<elementType>();
            format = new List<elementType>();
            identifier = new List<elementType>();
            source = new List<elementType>();
            language = new List<elementType>();
            relation = new List<elementType>();
            coverage = new List<elementType>();
            rights = new List<elementType>();
        }
    }
}