using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class CaseIdentificationType : IHaveDefaultValues
    {
        public CaseIdentificationType()
        {

        }

        private Nullable<bool> _isPrimary;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPrimary
        {
            get
            {
                if (_isPrimary.HasValue)
                    return _isPrimary.Value;
                return true; //default value;
            }
            set
            {
                this._isPrimary = value;
            }
        }

        public bool ShouldSerializeisPrimary()
        {
            return _isPrimary.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public FixedIdentifierType FixedIdentifier { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ConditionalIdentifierType ConditionalIdentifier { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void SetDefaultValues(bool shouldSet)
        {
            if(shouldSet)
            {
                if (!_isPrimary.HasValue) _isPrimary = true;
            }
        }
    }
}