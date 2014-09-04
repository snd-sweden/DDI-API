using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class DynamicTextType : IHaveDefaultValues
    {
        public DynamicTextType()
        {
            this.TextContent = new List<TextContentType>();
        }

        private Nullable<bool> _isStructureRequired;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isStructureRequired
        {
            get
            {
                if (_isStructureRequired.HasValue)
                    return _isStructureRequired.Value;
                return false; //default value;
            }
            set
            {
                this._isStructureRequired = value;
            }
        }

        public bool ShouldSerializeisStructureRequired()
        {
            return _isStructureRequired.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string audienceLanguage { get; set; }


        [System.Xml.Serialization.XmlElement("ConditionalText", typeof(ConditionalTextType), Order = 0)]
        [System.Xml.Serialization.XmlElement("LiteralText", typeof(LiteralTextType), Order = 0)]
        public List<TextContentType> TextContent { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {         
                if (!this._isStructureRequired.HasValue) this._isStructureRequired = false;
            }
        }
    }
}