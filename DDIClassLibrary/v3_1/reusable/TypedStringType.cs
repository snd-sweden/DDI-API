using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class TypedStringType : InternationalStringType
    {
        public TypedStringType()
        {
        }

        public TypedStringType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        #region conversion

        public static implicit operator string(TypedStringType content)
        {
            return content.Content;
        }

        public static implicit operator TypedStringType(string n)
        {
            return new TypedStringType(n);
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

        public static TypedStringType operator +(TypedStringType content)
        {
            throw new Exception();
        }

        public static TypedStringType operator -(TypedStringType content)
        {
            throw new Exception();
        }

        public static TypedStringType operator !(TypedStringType content)
        {
            throw new Exception();
        }

        public static TypedStringType operator ~(TypedStringType content)
        {
            throw new Exception();
        }

        public static TypedStringType operator ++(TypedStringType content)
        {
            throw new Exception();
        }

        public static TypedStringType operator --(TypedStringType content)
        {
            throw new Exception();
        }

        public static bool operator true(TypedStringType content)
        {
            throw new Exception();
        }

        public static bool operator false(TypedStringType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static TypedStringType operator +(TypedStringType content, string n)
        {
            return content.Content + n;
        }

        public static TypedStringType operator -(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator *(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator /(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator %(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator &(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator |(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator ^(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static TypedStringType operator <<(TypedStringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static TypedStringType operator >>(TypedStringType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(TypedStringType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(TypedStringType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(TypedStringType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(TypedStringType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}