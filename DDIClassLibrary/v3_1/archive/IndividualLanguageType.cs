using System;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class IndividualLanguageType
    {
        public IndividualLanguageType()
        {
        }

        public IndividualLanguageType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "language")]
        public string ISO { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public LanguageLevelCodeType read { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public LanguageLevelCodeType speak { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public LanguageLevelCodeType write { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(IndividualLanguageType content)
        {
            return content.Content;
        }

        public static implicit operator IndividualLanguageType(string n)
        {
            return new IndividualLanguageType(n);
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

        public static IndividualLanguageType operator +(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator -(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator !(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator ~(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator ++(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator --(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static bool operator true(IndividualLanguageType content)
        {
            throw new Exception();
        }

        public static bool operator false(IndividualLanguageType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static IndividualLanguageType operator +(IndividualLanguageType content, string n)
        {
            return content.Content + n;
        }

        public static IndividualLanguageType operator -(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator *(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator /(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator %(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator &(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator |(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator ^(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static IndividualLanguageType operator <<(IndividualLanguageType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static IndividualLanguageType operator >>(IndividualLanguageType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(IndividualLanguageType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(IndividualLanguageType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(IndividualLanguageType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}