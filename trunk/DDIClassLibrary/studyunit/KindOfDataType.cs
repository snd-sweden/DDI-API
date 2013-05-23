using System;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.studyunit
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:studyunit:3_1")]
    public class KindOfDataType : CodeValueType
    {
        [System.Xml.Serialization.XmlAttribute()]
        public KindOfDataTypeType type { get; set; }

        public KindOfDataType()
        {
        }

        public KindOfDataType(string content)
        {
            this.Content = content;
        }

        #region conversion

        public static implicit operator string(KindOfDataType content)
        {
            return content.Content;
        }

        public static implicit operator KindOfDataType(string n)
        {
            return new KindOfDataType(n);
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

        public static KindOfDataType operator +(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator -(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator !(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator ~(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator ++(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator --(KindOfDataType content)
        {
            throw new Exception();
        }

        public static bool operator true(KindOfDataType content)
        {
            throw new Exception();
        }

        public static bool operator false(KindOfDataType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static KindOfDataType operator +(KindOfDataType content, string n)
        {
            return content.Content + n;
        }

        public static KindOfDataType operator -(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator *(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator /(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator %(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator &(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator |(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator ^(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator <<(KindOfDataType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static KindOfDataType operator >>(KindOfDataType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(KindOfDataType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(KindOfDataType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}