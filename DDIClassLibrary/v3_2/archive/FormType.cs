using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class FormType
    {
        public FormType()
        {
            this.Statement = new List<InternationalStringType>();
        }

        private Nullable<bool> _isRequired;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isRequired
        {
            get
            {
                if (_isRequired.HasValue)
                    return _isRequired.Value;
                return false; //default value;
            }
            set
            {
                this._isRequired = value;
            }
        }

        public bool ShouldSerializeisRequired()
        {
            return _isRequired.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string FormNumber { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public string URI { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> Statement { get; set; }
    }
}