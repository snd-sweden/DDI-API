using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_1")]
    public class RecordLayoutType : BaseRecordLayoutType, IHaveDefaultValues
    {
        public RecordLayoutType()
        {
            this.ObjectType = "RecordLayout";

            this.DataItem = new List<DataItemType>();
        }

        private Nullable<bool> _namesOnFirstRow;

        [System.Xml.Serialization.XmlAttribute()]
        public bool namesOnFirstRow
        {
            get
            {
                if (_namesOnFirstRow.HasValue)
                    return _namesOnFirstRow.Value;
                return false; //default value;
            }
            set
            {
                this._namesOnFirstRow = value;
            }
        }

        public bool ShouldSerializenamesOnFirstRow()
        {
            return _namesOnFirstRow.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType CharacterSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public int ArrayBase { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public ReferenceType DefaultVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 3)]
        public List<DataItemType> DataItem { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._namesOnFirstRow.HasValue) this._namesOnFirstRow = false;
            }
        }
    }
}