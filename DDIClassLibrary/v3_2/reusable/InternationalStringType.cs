using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class InternationalStringType
    {
        public InternationalStringType()
        {
            this.String = new List<StringType>();
        }

        public InternationalStringType(string content)
        {
            this.String = new List<StringType>();
            this.String.Add(new StringType()
            {               
                Content = content
            });
        }

        public InternationalStringType(string content, string lang)
        {
            this.String = new List<StringType>();
            this.String.Add(new StringType()
            {
                lang = lang,
                Content = content
            });
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<StringType> String { get; set; }
    }
}