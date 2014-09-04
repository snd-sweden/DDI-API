using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class UserIDType
    {
        public UserIDType()
        {
        }

        public UserIDType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(UserIDType content)
        {
            return content.Content;
        }

        public static implicit operator UserIDType(string n)
        {
            return new UserIDType(n);
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

        public static UserIDType operator +(UserIDType content)
        {
            throw new Exception();
        }

        public static UserIDType operator -(UserIDType content)
        {
            throw new Exception();
        }

        public static UserIDType operator !(UserIDType content)
        {
            throw new Exception();
        }

        public static UserIDType operator ~(UserIDType content)
        {
            throw new Exception();
        }

        public static UserIDType operator ++(UserIDType content)
        {
            throw new Exception();
        }

        public static UserIDType operator --(UserIDType content)
        {
            throw new Exception();
        }

        public static bool operator true(UserIDType content)
        {
            throw new Exception();
        }

        public static bool operator false(UserIDType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static UserIDType operator +(UserIDType content, string n)
        {
            return content.Content + n;
        }

        public static UserIDType operator -(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator *(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator /(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator %(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator &(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator |(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator ^(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static UserIDType operator <<(UserIDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static UserIDType operator >>(UserIDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(UserIDType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(UserIDType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(UserIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(UserIDType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}