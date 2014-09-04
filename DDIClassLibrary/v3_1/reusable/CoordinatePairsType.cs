using System;
namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CoordinatePairsType : TextRepresentationType, IHaveDefaultValues
    {
        public CoordinatePairsType()
        {

        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        private Nullable<int> _maxArray;

        [System.Xml.Serialization.XmlAttribute()]
        public int maxArray
        {
            get
            {
                if (_maxArray.HasValue)
                    return _maxArray.Value;
                return 1; //default value;
            }
            set
            {
                this._maxArray = value;
            }
        }

        public bool ShouldSerializemaxArray()
        {
            return _maxArray.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string arraySeparator { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!_maxArray.HasValue) _maxArray = 1;
            }
        }
    }
}