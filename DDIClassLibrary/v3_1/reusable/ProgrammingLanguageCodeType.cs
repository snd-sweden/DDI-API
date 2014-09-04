using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ProgrammingLanguageCodeType
    {
        public ProgrammingLanguageCodeType()
        {
        }

        public ProgrammingLanguageCodeType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public bool programmingLanguage { get; set; }

        #region conversion

        public static implicit operator string(ProgrammingLanguageCodeType content)
        {
            return content.Content;
        }

        public static implicit operator ProgrammingLanguageCodeType(string n)
        {
            return new ProgrammingLanguageCodeType(n);
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

        public static ProgrammingLanguageCodeType operator +(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator -(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator !(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator ~(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator ++(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator --(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static bool operator true(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        public static bool operator false(ProgrammingLanguageCodeType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ProgrammingLanguageCodeType operator +(ProgrammingLanguageCodeType content, string n)
        {
            return content.Content + n;
        }

        public static ProgrammingLanguageCodeType operator -(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator *(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator /(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator %(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator &(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator |(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator ^(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static ProgrammingLanguageCodeType operator <<(ProgrammingLanguageCodeType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ProgrammingLanguageCodeType operator >>(ProgrammingLanguageCodeType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ProgrammingLanguageCodeType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ProgrammingLanguageCodeType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ProgrammingLanguageCodeType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}