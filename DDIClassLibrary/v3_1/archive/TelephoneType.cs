using System;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class TelephoneType
    {
        public TelephoneType()
        {
        }

        public TelephoneType(string content)
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

        public static implicit operator string(TelephoneType content)
        {
            return content.Content;
        }

        public static implicit operator TelephoneType(string n)
        {
            return new TelephoneType(n);
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

        public static TelephoneType operator +(TelephoneType content)
        {
            throw new Exception();
        }

        public static TelephoneType operator -(TelephoneType content)
        {
            throw new Exception();
        }

        public static TelephoneType operator !(TelephoneType content)
        {
            throw new Exception();
        }

        public static TelephoneType operator ~(TelephoneType content)
        {
            throw new Exception();
        }

        public static TelephoneType operator ++(TelephoneType content)
        {
            throw new Exception();
        }

        public static TelephoneType operator --(TelephoneType content)
        {
            throw new Exception();
        }

        public static bool operator true(TelephoneType content)
        {
            throw new Exception();
        }

        public static bool operator false(TelephoneType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static TelephoneType operator +(TelephoneType content, string n)
        {
            return content.Content + n;
        }

        public static TelephoneType operator -(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator *(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator /(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator %(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator &(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator |(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator ^(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static TelephoneType operator <<(TelephoneType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static TelephoneType operator >>(TelephoneType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(TelephoneType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(TelephoneType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(TelephoneType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(TelephoneType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}