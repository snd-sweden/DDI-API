using System;

namespace DDIClassLibrary.v3_1.dcelements
{
    public class elementType
    {
        public elementType()
        {
        }

        public elementType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        #region conversion

        public static implicit operator string(elementType content)
        {
            return content.Content;
        }

        public static implicit operator elementType(string n)
        {
            return new elementType(n);
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

        public static elementType operator +(elementType content)
        {
            throw new Exception();
        }

        public static elementType operator -(elementType content)
        {
            throw new Exception();
        }

        public static elementType operator !(elementType content)
        {
            throw new Exception();
        }

        public static elementType operator ~(elementType content)
        {
            throw new Exception();
        }

        public static elementType operator ++(elementType content)
        {
            throw new Exception();
        }

        public static elementType operator --(elementType content)
        {
            throw new Exception();
        }

        public static bool operator true(elementType content)
        {
            throw new Exception();
        }

        public static bool operator false(elementType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static elementType operator +(elementType content, string n)
        {
            return content.Content + n;
        }

        public static elementType operator -(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator *(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator /(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator %(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator &(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator |(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator ^(elementType content, string n)
        {
            throw new Exception();
        }

        public static elementType operator <<(elementType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static elementType operator >>(elementType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(elementType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(elementType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(elementType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(elementType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(elementType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(elementType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}