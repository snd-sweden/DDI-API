using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class MeasureDimensionValueType : IHaveDefaultValues
    {
        public MeasureDimensionValueType()
        {

        }

        private Nullable<int> _dimensionValue;

        [System.Xml.Serialization.XmlAttribute()]
        public int dimensionValue
        {
            get
            {
                if (_dimensionValue.HasValue)
                    return _dimensionValue.Value;
                return 0; //default value;
            }
            set
            {
                this._dimensionValue = value;
            }
        }

        public bool ShouldSerializedimensionValue()
        {
            return _dimensionValue.HasValue;
        }

        private Nullable<int> _arrayOrder;

        [System.Xml.Serialization.XmlAttribute()]
        public int arrayOrder
        {
            get
            {
                if (_arrayOrder.HasValue)
                    return _arrayOrder.Value;
                return 0; //default value;
            }
            set
            {
                this._arrayOrder = value;
            }
        }

        public bool ShouldSerializearrayOrder()
        {
            return _arrayOrder.HasValue;
        }


        public void SetDefaultValues(bool shouldSet)
        {
            if(shouldSet)
            {
                if (!_arrayOrder.HasValue) _arrayOrder = 0;
            }
        }
    }
}