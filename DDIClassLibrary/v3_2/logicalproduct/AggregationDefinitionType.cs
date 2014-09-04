using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class AggregationDefinitionType : IHaveDefaultValues
    {
        public AggregationDefinitionType()
        {
            this.IndependentDimension = new List<int>();
            this.DependentDimension = new List<int>();
        }

        private Nullable<bool> _isNCubeUniverse;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isNCubeUniverse
        {
            get
            {
                if (_isNCubeUniverse.HasValue)
                    return _isNCubeUniverse.Value;
                return true; //default value;
            }
            set
            {
                this._isNCubeUniverse = value;
            }
        }

        public bool ShouldSerializeisNCubeUniverse()
        {
            return _isNCubeUniverse.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<int> IndependentDimension { get; set; }

        public bool ShouldSerializeIndependentDimension()
        {
            return IndependentDimension.Count > 0;
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public List<int> DependentDimension { get; set; }

        public bool ShouldSerializeDependentDimension()
        {
            return DependentDimension.Count > 0;
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isNCubeUniverse.HasValue) this._isNCubeUniverse = true;
            }
        }
    }
}