using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class HistoricalDateType
    {
        public HistoricalDateType()
        {
        }

        public HistoricalDateType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string historicalDateFormat { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(HistoricalDateType content)
        {
            return content.Content;
        }

        public static implicit operator HistoricalDateType(string n)
        {
            return new HistoricalDateType(n);
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

        public static HistoricalDateType operator +(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator -(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator !(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator ~(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator ++(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator --(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static bool operator true(HistoricalDateType content)
        {
            throw new Exception();
        }

        public static bool operator false(HistoricalDateType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static HistoricalDateType operator +(HistoricalDateType content, string n)
        {
            return content.Content + n;
        }

        public static HistoricalDateType operator -(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator *(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator /(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator %(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator &(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator |(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator ^(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static HistoricalDateType operator <<(HistoricalDateType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static HistoricalDateType operator >>(HistoricalDateType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(HistoricalDateType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(HistoricalDateType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(HistoricalDateType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}