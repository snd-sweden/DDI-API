using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class URIType : IHaveDefaultValues
    {
        public URIType()
        {

        }

        public URIType(string content)
        {
            this.Content = content;
        }
        
        private Nullable<bool> _isPublic;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPublic
        {
            get
            {
                if (_isPublic.HasValue)
                    return _isPublic.Value;
                return true; //default value;
            }
            set
            {
                this._isPublic = value;
            }
        }

        public bool ShouldSerializeisPublic()
        {
            return _isPublic.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(URIType content)
        {
            return content.Content;
        }

        public static implicit operator URIType(string n)
        {
            return new URIType(n);
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

        public static URIType operator +(URIType content)
        {
            throw new Exception();
        }

        public static URIType operator -(URIType content)
        {
            throw new Exception();
        }

        public static URIType operator !(URIType content)
        {
            throw new Exception();
        }

        public static URIType operator ~(URIType content)
        {
            throw new Exception();
        }

        public static URIType operator ++(URIType content)
        {
            throw new Exception();
        }

        public static URIType operator --(URIType content)
        {
            throw new Exception();
        }

        public static bool operator true(URIType content)
        {
            throw new Exception();
        }

        public static bool operator false(URIType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static URIType operator +(URIType content, string n)
        {
            return content.Content + n;
        }

        public static URIType operator -(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator *(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator /(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator %(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator &(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator |(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator ^(URIType content, string n)
        {
            throw new Exception();
        }

        public static URIType operator <<(URIType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static URIType operator >>(URIType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(URIType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(URIType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(URIType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(URIType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(URIType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(URIType content, string n)
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
                if (!this._isPublic.HasValue) this._isPublic = true;
            }
        }
    }
}