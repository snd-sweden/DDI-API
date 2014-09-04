using System;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class IncludedCodeReferenceType
    {
        public IncludedCodeReferenceType()
        {
        }

        public IncludedCodeReferenceType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int coordinateValue { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(IncludedCodeReferenceType content)
        {
            return content.Content;
        }

        public static implicit operator IncludedCodeReferenceType(string n)
        {
            return new IncludedCodeReferenceType(n);
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

        public static IncludedCodeReferenceType operator +(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator -(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator !(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator ~(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator ++(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator --(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static bool operator true(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        public static bool operator false(IncludedCodeReferenceType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static IncludedCodeReferenceType operator +(IncludedCodeReferenceType content, string n)
        {
            return content.Content + n;
        }

        public static IncludedCodeReferenceType operator -(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator *(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator /(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator %(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator &(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator |(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator ^(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static IncludedCodeReferenceType operator <<(IncludedCodeReferenceType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static IncludedCodeReferenceType operator >>(IncludedCodeReferenceType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(IncludedCodeReferenceType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(IncludedCodeReferenceType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(IncludedCodeReferenceType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}