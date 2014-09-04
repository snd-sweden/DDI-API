using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CountryType : CountryCodeType
    {
        public CountryType()
        {

        }

        public CountryType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

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