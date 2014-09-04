using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RankingRangeType : RangeType, IHaveDefaultValues
    {
        public RankingRangeType()
        {
            
        }

        private Nullable<int> _maximumRepetitionOfSingleValue;

        [System.Xml.Serialization.XmlAttribute()]
        public int maximumRepetitionOfSingleValue
        {
            get
            {
                if (_maximumRepetitionOfSingleValue.HasValue)
                    return _maximumRepetitionOfSingleValue.Value;
                return 1; //default value;
            }
            set
            {
                this._maximumRepetitionOfSingleValue = value;
            }
        }

        public bool ShouldSerializemaximumRepetitionOfSingleValue()
        {
            return _maximumRepetitionOfSingleValue.HasValue;
        }

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!_maximumRepetitionOfSingleValue.HasValue) _maximumRepetitionOfSingleValue = 1;
            }
        }
    }
}