using System;

namespace DDIClassLibrary.v3_2.ddiprofile
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:ddiprofile:3_2")]
    public class NotUsedType
    {
        public NotUsedType()
        {
        }

        public NotUsedType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string xpath { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(NotUsedType content)
        {
            return content.Content;
        }

        public static implicit operator NotUsedType(string n)
        {
            return new NotUsedType(n);
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

        public static NotUsedType operator +(NotUsedType content)
        {
            throw new Exception();
        }

        public static NotUsedType operator -(NotUsedType content)
        {
            throw new Exception();
        }

        public static NotUsedType operator !(NotUsedType content)
        {
            throw new Exception();
        }

        public static NotUsedType operator ~(NotUsedType content)
        {
            throw new Exception();
        }

        public static NotUsedType operator ++(NotUsedType content)
        {
            throw new Exception();
        }

        public static NotUsedType operator --(NotUsedType content)
        {
            throw new Exception();
        }

        public static bool operator true(NotUsedType content)
        {
            throw new Exception();
        }

        public static bool operator false(NotUsedType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static NotUsedType operator +(NotUsedType content, string n)
        {
            return content.Content + n;
        }

        public static NotUsedType operator -(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator *(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator /(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator %(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator &(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator |(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator ^(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static NotUsedType operator <<(NotUsedType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static NotUsedType operator >>(NotUsedType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(NotUsedType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(NotUsedType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(NotUsedType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(NotUsedType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}