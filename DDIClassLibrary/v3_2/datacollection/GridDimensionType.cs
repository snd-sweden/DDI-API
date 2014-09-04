using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class GridDimensionType : IHaveDefaultValues
    {
        public GridDimensionType()
        {

        }

        private Nullable<int> _rank;

        [System.Xml.Serialization.XmlAttribute()]
        public int rank
        {
            get
            {
                if (_rank.HasValue)
                    return _rank.Value;
                return 1; //default value;
            }
            set
            {
                this._rank = value;
            }
        }

        public bool ShouldSerializerank()
        {
            return _rank.HasValue;
        }

        private Nullable<bool> _displayCode;

        [System.Xml.Serialization.XmlAttribute()]
        public bool displayCode
        {
            get
            {
                if (_displayCode.HasValue)
                    return _displayCode.Value;
                return true; //default value;
            }
            set
            {
                this._displayCode = value;
            }
        }

        public bool ShouldSerializedisplayCode()
        {
            return _displayCode.HasValue;
        }

        private Nullable<bool> _displayLabel;

        [System.Xml.Serialization.XmlAttribute()]
        public bool displayLabel
        {
            get
            {
                if (_displayLabel.HasValue)
                    return _displayLabel.Value;
                return true; //default value;
            }
            set
            {
                this._displayLabel = value;
            }
        }

        public bool ShouldSerializedisplayLabel()
        {
            return _displayLabel.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeDomainType CodeDomain { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public RosterType Roster { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._displayCode.HasValue) this._displayCode = true;
                if (!this._displayLabel.HasValue) this._displayLabel = true;
            }
        }
    }
}