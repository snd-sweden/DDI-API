using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ImageType
    {
        public ImageType()
        {
        }

        private Nullable<int> _dpi;

        [System.Xml.Serialization.XmlAttribute()]
        public int dpi
        {
            get
            {
                if (_dpi.HasValue)
                    return _dpi.Value;
                return 0; //default value;
            }
            set
            {
                this._dpi = value;
            }
        }

        public bool ShouldSerializedpi()
        {
            return _dpi.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string languageOfImage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public string ImageLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType TypeOfImage { get; set; }
    }
}