using System;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class PhysicalRecordSegmentType : IdentifiableType, IHaveDefaultValues
    {
        public PhysicalRecordSegmentType()
        {
            this.ObjectType = "PhysicalRecordSegment";
        }

        private Nullable<int> _segmentOrder;

        [System.Xml.Serialization.XmlAttribute()]
        public int segmentOrder
        {
            get
            {
                if (_segmentOrder.HasValue)
                    return _segmentOrder.Value;
                return 1; //default value;
            }
            set
            {
                this._segmentOrder = value;
            }
        }

        public bool ShouldSerializesegmentOrder()
        {
            return _segmentOrder.HasValue;
        }

        private Nullable<bool> _hasSegmentKey;

        [System.Xml.Serialization.XmlAttribute()]
        public bool hasSegmentKey
        {
            get
            {
                if (_hasSegmentKey.HasValue)
                    return _hasSegmentKey.Value;
                return false; //default value;
            }
            set
            {
                this._hasSegmentKey = value;
            }
        }

        public bool ShouldSerializehasSegmentKey()
        {
            return _hasSegmentKey.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public KeyVariableReferenceType KeyVariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string FileNameIdentification { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._segmentOrder.HasValue) _segmentOrder = 1;
                if (!this._hasSegmentKey.HasValue) _hasSegmentKey = false;
            }
        }
    }
}