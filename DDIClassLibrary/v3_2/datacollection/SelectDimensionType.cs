using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class SelectDimensionType
    {
        public SelectDimensionType()
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
                return 0; //default value;
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

        private Nullable<bool> _allValues;

        [System.Xml.Serialization.XmlAttribute()]
        public bool allValues
        {
            get
            {
                if (_allValues.HasValue)
                    return _allValues.Value;
                return false; //default value;
            }
            set
            {
                this._allValues = value;
            }
        }

        public bool ShouldSerializeallValues()
        {
            return _allValues.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string specificValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string rangeMinimum { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string rangeMaximum { get; set; }
    }
}