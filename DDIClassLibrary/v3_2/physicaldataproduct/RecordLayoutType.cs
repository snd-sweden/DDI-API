using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class RecordLayoutType : BaseRecordLayoutType, IHaveDefaultValues
    {
        public RecordLayoutType()
        {
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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CodeValueType CharacterSet { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public Nullable<int> ArrayBase { get; set; }

        public bool ShouldSerializeArrayBase()
        {
            return ArrayBase.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public SchemeReferenceType DefaultVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
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