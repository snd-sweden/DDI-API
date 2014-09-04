using System;

namespace DDIClassLibrary.v3_1.reusable
{
    public class NameType : InternationalStringType
    {
        [System.Xml.Serialization.XmlAttribute()]
        public bool isPreferred { get; set; }

        public NameType()
        {
        }

        public NameType(string content)
        {
            this.Content = content;
        }

        #region conversion

        public static implicit operator string(NameType content)
        {
            return content.Content;
        }

        public static implicit operator NameType(string n)
        {
            return new NameType(n);
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

        public static NameType operator +(NameType content)
        {
            throw new Exception();
        }

        public static NameType operator -(NameType content)
        {
            throw new Exception();
        }

        public static NameType operator !(NameType content)
        {
            throw new Exception();
        }

        public static NameType operator ~(NameType content)
        {
            throw new Exception();
        }

        public static NameType operator ++(NameType content)
        {
            throw new Exception();
        }

        public static NameType operator --(NameType content)
        {
            throw new Exception();
        }

        public static bool operator true(NameType content)
        {
            throw new Exception();
        }

        public static bool operator false(NameType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static NameType operator +(NameType content, string n)
        {
            return content.Content + n;
        }

        public static NameType operator -(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator *(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator /(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator %(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator &(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator |(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator ^(NameType content, string n)
        {
            throw new Exception();
        }

        public static NameType operator <<(NameType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static NameType operator >>(NameType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(NameType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(NameType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(NameType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(NameType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(NameType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(NameType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}