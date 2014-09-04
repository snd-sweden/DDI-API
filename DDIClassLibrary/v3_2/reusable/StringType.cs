using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class StringType : IHaveDefaultValues
    {
        public StringType()
        {

        }

        public StringType(string content)
        {
            this.Content = content;
        }

        public StringType(string content, string lang)
        {
            this.Content = content;
            this.lang = lang;
        }
        
        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        private Nullable<bool> _isTranslated;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isTranslated
        {
            get
            {
                if (_isTranslated.HasValue)
                    return _isTranslated.Value;
                return false; //default value;
            }
            set
            {
                this._isTranslated = value;
            }
        }

        public bool ShouldSerializeisTranslated()
        {
            return _isTranslated.HasValue;
        }

        private Nullable<bool> _isTranslatable;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isTranslatable
        {
            get
            {
                if (_isTranslatable.HasValue)
                    return _isTranslatable.Value;
                return true; //default value;
            }
            set
            {
                this._isTranslatable = value;
            }
        }

        public bool ShouldSerializeisTranslatable()
        {
            return _isTranslatable.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string translationSourceLanguage { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string translationDate { get; set; }

        #region conversion

        public static implicit operator string(StringType content)
        {
            return content.Content;
        }

        public static implicit operator StringType(string n)
        {
            return new StringType(n);
        }

        public override bool Equals(object obj)
        {
            return this.Content == (string)obj;
        }

        public override int GetHashCode()
        {
            return this.Content.GetHashCode();
        }

        #endregion conversion

        #region unary

        public static StringType operator +(StringType content)
        {
            throw new Exception();
        }

        public static StringType operator -(StringType content)
        {
            throw new Exception();
        }

        public static StringType operator !(StringType content)
        {
            throw new Exception();
        }

        public static StringType operator ~(StringType content)
        {
            throw new Exception();
        }

        public static StringType operator ++(StringType content)
        {
            throw new Exception();
        }

        public static StringType operator --(StringType content)
        {
            throw new Exception();
        }

        public static bool operator true(StringType content)
        {
            throw new Exception();
        }

        public static bool operator false(StringType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static StringType operator +(StringType content, string n)
        {
            return content.Content + n;
        }

        public static StringType operator -(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator *(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator /(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator %(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator &(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator |(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator ^(StringType content, string n)
        {
            throw new Exception();
        }

        public static StringType operator <<(StringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static StringType operator >>(StringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(StringType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(StringType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(StringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(StringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(StringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(StringType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isTranslated.HasValue) this._isTranslated = false;
                if (!this._isTranslatable.HasValue) this._isTranslatable = true;
            }
        }
    }
}