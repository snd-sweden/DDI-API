using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class StatisticalDataLocationType
    {
        public StatisticalDataLocationType()
        {

        }

        private Nullable<bool> _isInline;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isInline
        {
            get
            {
                if (_isInline.HasValue)
                    return _isInline.Value;
                return false; //default value;
            }
            set
            {
                this._isInline = value;
            }
        }

        public bool ShouldSerializeisInline()
        {
            return this._isInline.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType PhysicalInstanceReference { get; set; }

    }
}