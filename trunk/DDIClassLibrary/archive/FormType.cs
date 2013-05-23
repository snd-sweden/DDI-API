using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class FormType
    {
        public FormType()
        {
            this.Statement = new List<InternationalStringType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public Nullable<bool> Required { get; set; }

        public bool ShouldSerializeRequired()
        {
            return Required.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string FormNumber { get; set; }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 2)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<InternationalStringType> Statement { get; set; }
    }
}