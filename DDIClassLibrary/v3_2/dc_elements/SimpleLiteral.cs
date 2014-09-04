using System;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.dc_elements
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class SimpleLiteral
    {
        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        public SimpleLiteral()
        {
        }

        public SimpleLiteral(string content)
        {
            this.Content = content;
        }

        public SimpleLiteral(string content, string lang)
        {
            this.Content = content;
            this.lang = lang;
        }

        #region conversion

        public static implicit operator string(SimpleLiteral content)
        {
            return content.Content;
        }

        public static implicit operator SimpleLiteral(string n)
        {
            return new SimpleLiteral(n);
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

        public static SimpleLiteral operator +(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator -(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator !(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator ~(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator ++(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator --(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static bool operator true(SimpleLiteral content)
        {
            throw new Exception();
        }

        public static bool operator false(SimpleLiteral content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static SimpleLiteral operator +(SimpleLiteral content, string n)
        {
            return content.Content + n;
        }

        public static SimpleLiteral operator -(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator *(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator /(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator %(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator &(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator |(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator ^(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static SimpleLiteral operator <<(SimpleLiteral content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static SimpleLiteral operator >>(SimpleLiteral content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(SimpleLiteral content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(SimpleLiteral content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(SimpleLiteral content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}
