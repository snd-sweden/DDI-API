using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class NCubeMeasureDefinitionReferenceType : ReferenceType, IHaveDefaultValues
    {
        public NCubeMeasureDefinitionReferenceType()
        {

        }

        private Nullable<int> _orderValue;

        [System.Xml.Serialization.XmlAttribute()]
        public int orderValue
        {
            get
            {
                if (_orderValue.HasValue)
                    return _orderValue.Value;
                return 1; //default value;
            }
            set
            {
                this._orderValue = value;
            }
        }

        public bool ShouldSerializeorderValue()
        {
            return _orderValue.HasValue;
        }

        public override void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if(shouldSet)
            {
                if (!_orderValue.HasValue) _orderValue = 1;
            }
        }
    }
}