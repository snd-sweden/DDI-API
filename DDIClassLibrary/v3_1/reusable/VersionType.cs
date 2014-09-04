using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class VersionType
    {
        public VersionType()
        {
        }

        public VersionType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(VersionType content)
        {
            return content.Content;
        }

        public static implicit operator VersionType(string n)
        {
            return new VersionType(n);
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

        public static VersionType operator +(VersionType content)
        {
            throw new Exception();
        }

        public static VersionType operator -(VersionType content)
        {
            throw new Exception();
        }

        public static VersionType operator !(VersionType content)
        {
            throw new Exception();
        }

        public static VersionType operator ~(VersionType content)
        {
            throw new Exception();
        }

        public static VersionType operator ++(VersionType content)
        {
            throw new Exception();
        }

        public static VersionType operator --(VersionType content)
        {
            throw new Exception();
        }

        public static bool operator true(VersionType content)
        {
            throw new Exception();
        }

        public static bool operator false(VersionType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static VersionType operator +(VersionType content, string n)
        {
            return content.Content + n;
        }

        public static VersionType operator -(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator *(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator /(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator %(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator &(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator |(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator ^(VersionType content, string n)
        {
            throw new Exception();
        }

        public static VersionType operator <<(VersionType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static VersionType operator >>(VersionType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(VersionType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(VersionType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(VersionType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(VersionType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(VersionType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(VersionType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}