using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class InternationalStringType : IHaveDefaultValues
    {
        public InternationalStringType()
        {

        }

        public InternationalStringType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

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

        #region conversion

        public static implicit operator string(InternationalStringType content)
        {
            return content.Content;
        }

        public static implicit operator InternationalStringType(string n)
        {
            return new InternationalStringType(n);
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

        public static InternationalStringType operator +(InternationalStringType content)
        {
            throw new Exception();
        }

        public static InternationalStringType operator -(InternationalStringType content)
        {
            throw new Exception();
        }

        public static InternationalStringType operator !(InternationalStringType content)
        {
            throw new Exception();
        }

        public static InternationalStringType operator ~(InternationalStringType content)
        {
            throw new Exception();
        }

        public static InternationalStringType operator ++(InternationalStringType content)
        {
            throw new Exception();
        }

        public static InternationalStringType operator --(InternationalStringType content)
        {
            throw new Exception();
        }

        public static bool operator true(InternationalStringType content)
        {
            throw new Exception();
        }

        public static bool operator false(InternationalStringType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static InternationalStringType operator +(InternationalStringType content, string n)
        {
            return content.Content + n;
        }

        public static InternationalStringType operator -(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator *(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator /(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator %(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator &(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator |(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator ^(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static InternationalStringType operator <<(InternationalStringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static InternationalStringType operator >>(InternationalStringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(InternationalStringType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(InternationalStringType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(InternationalStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(InternationalStringType content, string n)
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
                if (!this._translatable.HasValue) this._translatable = true;
                if (!this._translated.HasValue) this._translated = false;
            }
        }
    }
}