using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ContentType : IHaveDefaultValues
    {
        public ContentType()
        {

        }

        public ContentType(string content)
        {
            this.Content = content;
        }

        public ContentType(string content, string lang)
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

        private Nullable<bool> _isPlainText;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPlainText
        {
            get
            {
                if (_isPlainText.HasValue)
                    return _isPlainText.Value;
                return true; //default value;
            }
            set
            {
                this.isPlainText = value;
            }
        }

        public bool ShouldSerializeisPlainText()
        {
            return _isPlainText.HasValue;
        }

        #region conversion

        public static implicit operator string(ContentType content)
        {
            return content.Content;
        }

        public static implicit operator ContentType(string n)
        {
            return new ContentType(n);
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

        public static ContentType operator +(ContentType content)
        {
            throw new Exception();
        }

        public static ContentType operator -(ContentType content)
        {
            throw new Exception();
        }

        public static ContentType operator !(ContentType content)
        {
            throw new Exception();
        }

        public static ContentType operator ~(ContentType content)
        {
            throw new Exception();
        }

        public static ContentType operator ++(ContentType content)
        {
            throw new Exception();
        }

        public static ContentType operator --(ContentType content)
        {
            throw new Exception();
        }

        public static bool operator true(ContentType content)
        {
            throw new Exception();
        }

        public static bool operator false(ContentType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ContentType operator +(ContentType content, string n)
        {
            return content.Content + n;
        }

        public static ContentType operator -(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator *(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator /(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator %(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator &(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator |(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator ^(ContentType content, string n)
        {
            throw new Exception();
        }

        public static ContentType operator <<(ContentType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ContentType operator >>(ContentType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ContentType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ContentType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ContentType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ContentType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ContentType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ContentType content, string n)
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
                if (!this._isPlainText.HasValue) this._isPlainText = true;
            }
        }
    }
}