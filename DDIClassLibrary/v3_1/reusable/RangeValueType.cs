using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class RangeValueType
    {
        public RangeValueType()
        {
        }

        public RangeValueType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public bool included { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(RangeValueType content)
        {
            return content.Content;
        }

        public static implicit operator RangeValueType(string n)
        {
            return new RangeValueType(n);
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

        public static RangeValueType operator +(RangeValueType content)
        {
            throw new Exception();
        }

        public static RangeValueType operator -(RangeValueType content)
        {
            throw new Exception();
        }

        public static RangeValueType operator !(RangeValueType content)
        {
            throw new Exception();
        }

        public static RangeValueType operator ~(RangeValueType content)
        {
            throw new Exception();
        }

        public static RangeValueType operator ++(RangeValueType content)
        {
            throw new Exception();
        }

        public static RangeValueType operator --(RangeValueType content)
        {
            throw new Exception();
        }

        public static bool operator true(RangeValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(RangeValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static RangeValueType operator +(RangeValueType content, string n)
        {
            return content.Content + n;
        }

        public static RangeValueType operator -(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator *(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator /(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator %(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator &(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator |(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator ^(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static RangeValueType operator <<(RangeValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static RangeValueType operator >>(RangeValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(RangeValueType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(RangeValueType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(RangeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(RangeValueType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}