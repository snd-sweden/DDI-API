using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class InternetEmailType
    {
        public InternetEmailType()
        {
        }

        public InternetEmailType(string content)
        {
            this.Content = content;
        }
        
        private string _content;
        private string pattern = @"([\.a-zA-Z0-9_\-])+@([a-zA-Z0-9_\-])+(([a-zA-Z0-9_\-])*\.([a-zA-Z0-9_\-])+)+";

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

        public static implicit operator string(InternetEmailType content)
        {
            return content.Content;
        }

        public static implicit operator InternetEmailType(string n)
        {
            return new InternetEmailType(n);
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

        public static InternetEmailType operator +(InternetEmailType content)
        {
            throw new Exception();
        }

        public static InternetEmailType operator -(InternetEmailType content)
        {
            throw new Exception();
        }

        public static InternetEmailType operator !(InternetEmailType content)
        {
            throw new Exception();
        }

        public static InternetEmailType operator ~(InternetEmailType content)
        {
            throw new Exception();
        }

        public static InternetEmailType operator ++(InternetEmailType content)
        {
            throw new Exception();
        }

        public static InternetEmailType operator --(InternetEmailType content)
        {
            throw new Exception();
        }

        public static bool operator true(InternetEmailType content)
        {
            throw new Exception();
        }

        public static bool operator false(InternetEmailType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static InternetEmailType operator +(InternetEmailType content, string n)
        {
            return content.Content + n;
        }

        public static InternetEmailType operator -(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator *(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator /(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator %(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator &(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator |(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator ^(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static InternetEmailType operator <<(InternetEmailType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static InternetEmailType operator >>(InternetEmailType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(InternetEmailType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(InternetEmailType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(InternetEmailType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}