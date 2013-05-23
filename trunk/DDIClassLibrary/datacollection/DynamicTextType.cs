using System;
using System.Collections.Generic;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class DynamicTextType : IHaveDefaultValues
    {
        public DynamicTextType()
        {
            this.Text = new List<TextType>();
        }

        [System.Xml.Serialization.XmlElement("ConditionalText", typeof(ConditionalTextType), Order = 0)]
        [System.Xml.Serialization.XmlElement("LiteralText", typeof(LiteralTextType), Order = 0)]
        public List<TextType> Text { get; set; }

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

        private Nullable<bool> _translatable;

        [System.Xml.Serialization.XmlAttribute()]
        public bool translatable
        {
            get
            {
                if (_translatable.HasValue)
                    return _translatable.Value;
                return true; //default value;
            }
            set
            {
                this._translatable = value;
            }
        }

        public bool ShouldSerializetranslatable()
        {
            return _translatable.HasValue;
        }

        private Nullable<bool> _translated;

        [System.Xml.Serialization.XmlAttribute()]
        public bool translated
        {
            get
            {
                if (_translated.HasValue)
                    return _translated.Value;
                return false; //default value;
            }
            set
            {
                this._translated = value;
            }
        }

        public bool ShouldSerializetranslated()
        {
            return _translated.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._translatable.HasValue) this._translatable = true;
                if (!this._translated.HasValue) this._translated = false;
                if (!this._isStructureRequired.HasValue) this._isStructureRequired = false;
            }
        }
    }
}