using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CreatorType : InternationalStringType
    {
        public CreatorType()
        {
        }

        public CreatorType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string affiliation { get; set; }

        #region conversion

        public static implicit operator string(CreatorType content)
        {
            return content.Content;
        }

        public static implicit operator CreatorType(string n)
        {
            return new CreatorType(n);
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

        public static CreatorType operator +(CreatorType content)
        {
            throw new Exception();
        }

        public static CreatorType operator -(CreatorType content)
        {
            throw new Exception();
        }

        public static CreatorType operator !(CreatorType content)
        {
            throw new Exception();
        }

        public static CreatorType operator ~(CreatorType content)
        {
            throw new Exception();
        }

        public static CreatorType operator ++(CreatorType content)
        {
            throw new Exception();
        }

        public static CreatorType operator --(CreatorType content)
        {
            throw new Exception();
        }

        public static bool operator true(CreatorType content)
        {
            throw new Exception();
        }

        public static bool operator false(CreatorType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static CreatorType operator +(CreatorType content, string n)
        {
            return content.Content + n;
        }

        public static CreatorType operator -(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator *(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator /(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator %(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator &(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator |(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator ^(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static CreatorType operator <<(CreatorType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static CreatorType operator >>(CreatorType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(CreatorType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(CreatorType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(CreatorType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(CreatorType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}