using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class DataFingerprintType
    {
        public DataFingerprintType()
        {

        }

        private Nullable<DataFingerprintObjectType> _type;

        [System.Xml.Serialization.XmlAttribute()]
        public DataFingerprintObjectType type
        {
            get
            {
                if (_type.HasValue)
                    return _type.Value;
                return 0; //default value;
            }
            set
            {
                this._type = value;
            }
        }

        public bool ShouldSerializetype()
        {
            return _type.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string DataFingerprintValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string AlgorithmSpecification { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string AlgorithmVersion { get; set; }
    }
}