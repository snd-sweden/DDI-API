using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class OneCharStringType
    {
        public OneCharStringType()
        {
        }

        public OneCharStringType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        private string _content;

        [System.Xml.Serialization.XmlText()]
        public string Content
        {
            get { return this._content; }
            set
            {
                if (value.Length > 1)
                    throw new System.ArgumentException("value cannot be more than one character");
                else
                    this._content = value;
            }
        }

        #region conversion

        public static implicit operator string(OneCharStringType content)
        {
            return content.Content;
        }

        public static implicit operator OneCharStringType(string n)
        {
            return new OneCharStringType(n);
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

        public static OneCharStringType operator +(OneCharStringType content)
        {
            throw new Exception();
        }

        public static OneCharStringType operator -(OneCharStringType content)
        {
            throw new Exception();
        }

        public static OneCharStringType operator !(OneCharStringType content)
        {
            throw new Exception();
        }

        public static OneCharStringType operator ~(OneCharStringType content)
        {
            throw new Exception();
        }

        public static OneCharStringType operator ++(OneCharStringType content)
        {
            throw new Exception();
        }

        public static OneCharStringType operator --(OneCharStringType content)
        {
            throw new Exception();
        }

        public static bool operator true(OneCharStringType content)
        {
            throw new Exception();
        }

        public static bool operator false(OneCharStringType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static OneCharStringType operator +(OneCharStringType content, string n)
        {
            return content.Content + n;
        }

        public static OneCharStringType operator -(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator *(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator /(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator %(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator &(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator |(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator ^(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static OneCharStringType operator <<(OneCharStringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static OneCharStringType operator >>(OneCharStringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(OneCharStringType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(OneCharStringType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(OneCharStringType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}