using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class IDType : IHaveDefaultValues
    {
        public IDType()
        {
        }

        public IDType(string content)
        {
            this.Content = content;
        }

        private string _type;

        [System.Xml.Serialization.XmlAttribute()]
        public string type 
        { 
            get 
            { 
                return "ID";             
            }
            set
            {
                this._type = value;
            }
        }

        public bool ShouldSerializetype()
        {
            if (!String.IsNullOrEmpty(_type))
                return true;
            return false;
        }

        private string _content;
        private static string pattern = @"([A-Z]|[a-z]|\*|@|[0-9]|_|$|\-)*";

        [System.Xml.Serialization.XmlText()]
        public string Content
        {
            get { return this._content; }
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, pattern))
                    throw new System.ArgumentException("value does not match pattern");
                else
                    this._content = value;
            }
        }

        #region conversion

        public static implicit operator string(IDType content)
        {
            return content.Content;
        }

        public static implicit operator IDType(string n)
        {
            return new IDType(n);
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

        public static IDType operator +(IDType content)
        {
            throw new Exception();
        }

        public static IDType operator -(IDType content)
        {
            throw new Exception();
        }

        public static IDType operator !(IDType content)
        {
            throw new Exception();
        }

        public static IDType operator ~(IDType content)
        {
            throw new Exception();
        }

        public static IDType operator ++(IDType content)
        {
            throw new Exception();
        }

        public static IDType operator --(IDType content)
        {
            throw new Exception();
        }

        public static bool operator true(IDType content)
        {
            throw new Exception();
        }

        public static bool operator false(IDType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static IDType operator +(IDType content, string n)
        {
            return content.Content + n;
        }

        public static IDType operator -(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator *(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator /(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator %(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator &(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator |(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator ^(IDType content, string n)
        {
            throw new Exception();
        }

        public static IDType operator <<(IDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static IDType operator >>(IDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(IDType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(IDType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(IDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(IDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(IDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(IDType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                this._type = "ID";
            }
        }
    }
}