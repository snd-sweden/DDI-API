using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class URNType
    {
        public URNType()
        {
        }

        public URNType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get { return "URN"; } }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(URNType content)
        {
            return content.Content;
        }

        public static implicit operator URNType(string n)
        {
            return new URNType(n);
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

        public static URNType operator +(URNType content)
        {
            throw new Exception();
        }

        public static URNType operator -(URNType content)
        {
            throw new Exception();
        }

        public static URNType operator !(URNType content)
        {
            throw new Exception();
        }

        public static URNType operator ~(URNType content)
        {
            throw new Exception();
        }

        public static URNType operator ++(URNType content)
        {
            throw new Exception();
        }

        public static URNType operator --(URNType content)
        {
            throw new Exception();
        }

        public static bool operator true(URNType content)
        {
            throw new Exception();
        }

        public static bool operator false(URNType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static URNType operator +(URNType content, string n)
        {
            return content.Content + n;
        }

        public static URNType operator -(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator *(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator /(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator %(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator &(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator |(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator ^(URNType content, string n)
        {
            throw new Exception();
        }

        public static URNType operator <<(URNType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static URNType operator >>(URNType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(URNType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(URNType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(URNType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(URNType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(URNType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(URNType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}