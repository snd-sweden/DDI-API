using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class CodeValueType : IHaveDefaultValues
    {
        public CodeValueType()
        {
            
        }

        public CodeValueType(string content)
        {
            this.Content = content;
        }

        private string _content;

        [System.Xml.Serialization.XmlText()]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListAgencyName { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListID { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListName { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListSchemeURN { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListURN { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListVersionID { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string otherValue { get; set; }

        #region conversion

        public static implicit operator string(CodeValueType content)
        {
            return content.Content;
        }

        public static implicit operator CodeValueType(string n)
        {
            return new CodeValueType(n);
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

        public static CodeValueType operator +(CodeValueType content)
        {
            throw new Exception();
        }

        public static CodeValueType operator -(CodeValueType content)
        {
            throw new Exception();
        }

        public static CodeValueType operator !(CodeValueType content)
        {
            throw new Exception();
        }

        public static CodeValueType operator ~(CodeValueType content)
        {
            throw new Exception();
        }

        public static CodeValueType operator ++(CodeValueType content)
        {
            throw new Exception();
        }

        public static CodeValueType operator --(CodeValueType content)
        {
            throw new Exception();
        }

        public static bool operator true(CodeValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(CodeValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static CodeValueType operator +(CodeValueType content, string n)
        {
            return content.Content + n;
        }

        public static CodeValueType operator -(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator *(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator /(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator %(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator &(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator |(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator ^(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static CodeValueType operator <<(CodeValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static CodeValueType operator >>(CodeValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(CodeValueType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(CodeValueType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(CodeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(CodeValueType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (String.IsNullOrEmpty(codeListVersionID)) this.codeListVersionID = "1.0";
            }
        }
    }
}