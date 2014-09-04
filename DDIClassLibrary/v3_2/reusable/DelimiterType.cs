using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DelimiterType : IHaveDefaultValues
    {
        public DelimiterType()
        {
            
        }

        public DelimiterType(string content)
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
        public string otherValue { get; set; }

        private Nullable<bool> _treatConsecutiveDelimiterAsOne;

        [System.Xml.Serialization.XmlAttribute()]
        public bool treatConsecutiveDelimiterAsOne
        {
            get
            {
                if (_treatConsecutiveDelimiterAsOne.HasValue)
                    return _treatConsecutiveDelimiterAsOne.Value;
                return false; //default value;
            }
            set
            {
                this._treatConsecutiveDelimiterAsOne = value;
            }
        }

        public bool ShouldSerializetreatConsecutiveDelimiterAsOne()
        {
            return _treatConsecutiveDelimiterAsOne.HasValue;
        }
        
        #region conversion

        public static implicit operator string(DelimiterType content)
        {
            return content.Content;
        }

        public static implicit operator DelimiterType(string n)
        {
            return new DelimiterType(n);
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

        public static DelimiterType operator +(DelimiterType content)
        {
            throw new Exception();
        }

        public static DelimiterType operator -(DelimiterType content)
        {
            throw new Exception();
        }

        public static DelimiterType operator !(DelimiterType content)
        {
            throw new Exception();
        }

        public static DelimiterType operator ~(DelimiterType content)
        {
            throw new Exception();
        }

        public static DelimiterType operator ++(DelimiterType content)
        {
            throw new Exception();
        }

        public static DelimiterType operator --(DelimiterType content)
        {
            throw new Exception();
        }

        public static bool operator true(DelimiterType content)
        {
            throw new Exception();
        }

        public static bool operator false(DelimiterType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static DelimiterType operator +(DelimiterType content, string n)
        {
            return content.Content + n;
        }

        public static DelimiterType operator -(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator *(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator /(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator %(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator &(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator |(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator ^(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static DelimiterType operator <<(DelimiterType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static DelimiterType operator >>(DelimiterType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(DelimiterType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(DelimiterType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(DelimiterType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(DelimiterType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!_treatConsecutiveDelimiterAsOne.HasValue) this._treatConsecutiveDelimiterAsOne = false;
            }
        }
    }
}