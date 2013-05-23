using System;
using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class GrossRecordStructureType : IdentifiableType, IHaveDefaultValues
    {
        public GrossRecordStructureType()
        {
            this.ObjectType = "GrossRecordStructure";

            this.PhysicalRecordSegment = new List<PhysicalRecordSegmentType>();
        }

        private Nullable<int> _numberOfPhysicalSegments;

        [System.Xml.Serialization.XmlAttribute()]
        public int numberOfPhysicalSegments
        {
            get
            {
                if (_numberOfPhysicalSegments.HasValue)
                    return _numberOfPhysicalSegments.Value;
                return 1; //default value;
            }
            set
            {
                this._numberOfPhysicalSegments = value;
            }
        }

        public bool ShouldSerializenumberOfPhysicalSegments()
        {
            return _numberOfPhysicalSegments.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType LogicalRecordReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<PhysicalRecordSegmentType> PhysicalRecordSegment { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!_numberOfPhysicalSegments.HasValue) _numberOfPhysicalSegments = 1;
            }
        }
    }
}