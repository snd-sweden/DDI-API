using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class GridAttachmentType : IHaveDefaultValues
    {
        public GridAttachmentType()
        {
            this.SpecificCellCoordinate = new List<string>();
            this.CellCoordinatesAsDefined = new List<CellCoordinatesAsDefinedType>();
        }

        private Nullable<bool> _allCells;

        [System.Xml.Serialization.XmlAttribute()]
        public bool allCells
        {
            get
            {
                if (_allCells.HasValue)
                    return _allCells.Value;
                return false; //default value;
            }
            set
            {
                this._allCells = value;
            }
        }

        public bool ShouldSerializeallCells()
        {
            return _allCells.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<string> SpecificCellCoordinate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CellCoordinatesAsDefinedType> CellCoordinatesAsDefined { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._allCells.HasValue) this._allCells = false;
            }
        }
    }
}