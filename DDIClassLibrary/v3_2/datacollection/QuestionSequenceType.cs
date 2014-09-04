using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class QuestionSequenceType : SpecificSequenceType
    {
        public QuestionSequenceType()
        {

        }

        private Nullable<HandlingType> _handlingOfStimulusMaterial;

        [System.Xml.Serialization.XmlAttribute()]
        public HandlingType handlingOfStimulusMaterial
        {
            get
            {
                if (_handlingOfStimulusMaterial.HasValue)
                    return _handlingOfStimulusMaterial.Value;
                return 0; //default value;
            }
            set
            {
                this._handlingOfStimulusMaterial = value;
            }
        }

        public bool ShouldSerializehandlingOfStimulusMaterial()
        {
            return _handlingOfStimulusMaterial.HasValue;
        }
    }
}