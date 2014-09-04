using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CountryCodeType
    {
        public CountryCodeType()
        {

        }

        public CountryCodeType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string effectiveDate { get; set; }

        #region conversion

        public static implicit operator string(CountryCodeType content)
        {
            return content.Content;
        }

        public static implicit operator CountryCodeType(string n)
        {
            return new CountryCodeType(n);
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

        public static CountryCodeType operator +(CountryCodeType content)
        {
            throw new Exception();
        }

        public static CountryCodeType operator -(CountryCodeType content)
        {
            throw new Exception();
        }

        public static CountryCodeType operator !(CountryCodeType content)
        {
            throw new Exception();
        }

        public static CountryCodeType operator ~(CountryCodeType content)
        {
            throw new Exception();
        }

        public static CountryCodeType operator ++(CountryCodeType content)
        {
            throw new Exception();
        }

        public static CountryCodeType operator --(CountryCodeType content)
        {
            throw new Exception();
        }

        public static bool operator true(CountryCodeType content)
        {
            throw new Exception();
        }

        public static bool operator false(CountryCodeType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static CountryCodeType operator +(CountryCodeType content, string n)
        {
            return content.Content + n;
        }

        public static CountryCodeType operator -(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator *(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator /(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator %(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator &(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator |(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator ^(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static CountryCodeType operator <<(CountryCodeType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static CountryCodeType operator >>(CountryCodeType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(CountryCodeType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(CountryCodeType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(CountryCodeType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}