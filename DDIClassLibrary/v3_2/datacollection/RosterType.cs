using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class RosterType : IHaveDefaultValues
    {
        public RosterType()
        {

        }

        private Nullable<int> _baseCodeValue;

        [System.Xml.Serialization.XmlAttribute()]
        public int baseCodeValue
        {
            get
            {
                if (_baseCodeValue.HasValue)
                    return _baseCodeValue.Value;
                return 0; //default value;
            }
            set
            {
                this._baseCodeValue = value;
            }
        }

        public bool ShouldSerializebaseCodeValue()
        {
            return _baseCodeValue.HasValue;
        }

        private Nullable<int> _codeIterationValue;

        [System.Xml.Serialization.XmlAttribute()]
        public int codeIterationValue
        {
            get
            {
                if (_codeIterationValue.HasValue)
                    return _codeIterationValue.Value;
                return 0; //default value;
            }
            set
            {
                this._codeIterationValue = value;
            }
        }

        public bool ShouldSerializecodeIterationValue()
        {
            return _codeIterationValue.HasValue;
        }

        private Nullable<int> _minimumRequired;

        [System.Xml.Serialization.XmlAttribute()]
        public int minimumRequired
        {
            get
            {
                if (_minimumRequired.HasValue)
                    return _minimumRequired.Value;
                return 1; //default value;
            }
            set
            {
                this._minimumRequired = value;
            }
        }

        public bool ShouldSerializeminimumRequired()
        {
            return _minimumRequired.HasValue;
        }

        private Nullable<int> _maximumAllowed;

        [System.Xml.Serialization.XmlAttribute()]
        public int maximumAllowed
        {
            get
            {
                if (_maximumAllowed.HasValue)
                    return _maximumAllowed.Value;
                return 1; //default value;
            }
            set
            {
                this._maximumAllowed = value;
            }
        }

        public bool ShouldSerializemaximumAllowed()
        {
            return _maximumAllowed.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public LabelType Label { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CommandCodeType ConditionForContinuation { get; set; }

        public void SetDefaultValues(bool shouldSet)
        {
            if(shouldSet)
            {
                if (!_minimumRequired.HasValue) _minimumRequired = 1;
            }
        }
    }
}