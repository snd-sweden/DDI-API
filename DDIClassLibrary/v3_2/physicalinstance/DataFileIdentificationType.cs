using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class DataFileIdentificationType
    {
        public DataFileIdentificationType()
        {

        }

        private Nullable<bool> _isMaster;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isMaster
        {
            get
            {
                if (_isMaster.HasValue)
                    return _isMaster.Value;
                return false; //default value;
            }
            set
            {
                this._isMaster = value;
            }
        }

        public bool ShouldSerializeisMaster()
        {
            return this._isMaster.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public InternationalStringType Location { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public URIType DataFileURI { get; set; }
    }
}