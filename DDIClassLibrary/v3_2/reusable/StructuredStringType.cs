using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class StructuredStringType
    {
        public StructuredStringType()
        {
            this.Content = new System.Collections.Generic.List<ContentType>();
        }

        public StructuredStringType(string content)
        {
            this.Content = new System.Collections.Generic.List<ContentType>();
            this.Content.Add(new ContentType(content));
        }

        public StructuredStringType(string content, string lang)
        {
            this.Content = new System.Collections.Generic.List<ContentType>();
            this.Content.Add(new ContentType(content, lang));
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public System.Collections.Generic.List<ContentType> Content { get; set; }
    }
}