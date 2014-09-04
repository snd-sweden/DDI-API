using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class URLType
    {
        public URLType()
        {

        }

        public URLType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        private Nullable<bool> _isPreferred;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPreferred
        {
            get
            {
                if (_isPreferred.HasValue)
                    return _isPreferred.Value;
                return false; //default value;
            }
            set
            {
                this._isPreferred = value;
            }
        }

        public bool ShouldSerializeisPreferred()
        {
            return _isPreferred.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }
               

        #region conversion

        public static implicit operator string(URLType content)
        {
            return content.Content;
        }

        public static implicit operator URLType(string n)
        {
            return new URLType(n);
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

        public static URLType operator +(URLType content)
        {
            throw new Exception();
        }

        public static URLType operator -(URLType content)
        {
            throw new Exception();
        }

        public static URLType operator !(URLType content)
        {
            throw new Exception();
        }

        public static URLType operator ~(URLType content)
        {
            throw new Exception();
        }

        public static URLType operator ++(URLType content)
        {
            throw new Exception();
        }

        public static URLType operator --(URLType content)
        {
            throw new Exception();
        }

        public static bool operator true(URLType content)
        {
            throw new Exception();
        }

        public static bool operator false(URLType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static URLType operator +(URLType content, string n)
        {
            return content.Content + n;
        }

        public static URLType operator -(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator *(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator /(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator %(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator &(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator |(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator ^(URLType content, string n)
        {
            throw new Exception();
        }

        public static URLType operator <<(URLType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static URLType operator >>(URLType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(URLType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(URLType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(URLType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(URLType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(URLType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(URLType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}