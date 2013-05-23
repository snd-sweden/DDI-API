using System;

namespace DDIClassLibrary.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class InstantMessagingType
    {
        public InstantMessagingType()
        {
        }

        public InstantMessagingType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(InstantMessagingType content)
        {
            return content.Content;
        }

        public static implicit operator InstantMessagingType(string n)
        {
            return new InstantMessagingType(n);
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

        public static InstantMessagingType operator +(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator -(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator !(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator ~(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator ++(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator --(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static bool operator true(InstantMessagingType content)
        {
            throw new Exception();
        }

        public static bool operator false(InstantMessagingType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static InstantMessagingType operator +(InstantMessagingType content, string n)
        {
            return content.Content + n;
        }

        public static InstantMessagingType operator -(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator *(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator /(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator %(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator &(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator |(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator ^(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static InstantMessagingType operator <<(InstantMessagingType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static InstantMessagingType operator >>(InstantMessagingType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(InstantMessagingType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(InstantMessagingType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(InstantMessagingType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}