using System;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_1")]
    public class MeasureReferenceType : ReferenceType, IHaveDefaultValues
    {
        public MeasureReferenceType()
        {
            
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

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!_arrayOrder.HasValue) _arrayOrder = 0;
            }
        }
    }
}