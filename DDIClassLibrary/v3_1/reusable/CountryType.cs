using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CountryType
    {
        public CountryType()
        {
        }

        public CountryType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string code { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeClass { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(CountryType content)
        {
            return content.Content;
        }

        public static implicit operator CountryType(string n)
        {
            return new CountryType(n);
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

        public static CountryType operator +(CountryType content)
        {
            throw new Exception();
        }

        public static CountryType operator -(CountryType content)
        {
            throw new Exception();
        }

        public static CountryType operator !(CountryType content)
        {
            throw new Exception();
        }

        public static CountryType operator ~(CountryType content)
        {
            throw new Exception();
        }

        public static CountryType operator ++(CountryType content)
        {
            throw new Exception();
        }

        public static CountryType operator --(CountryType content)
        {
            throw new Exception();
        }

        public static bool operator true(CountryType content)
        {
            throw new Exception();
        }

        public static bool operator false(CountryType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static CountryType operator +(CountryType content, string n)
        {
            return content.Content + n;
        }

        public static CountryType operator -(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator *(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator /(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator %(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator &(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator |(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator ^(CountryType content, string n)
        {
            throw new Exception();
        }

        public static CountryType operator <<(CountryType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static CountryType operator >>(CountryType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(CountryType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(CountryType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(CountryType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(CountryType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(CountryType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(CountryType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}