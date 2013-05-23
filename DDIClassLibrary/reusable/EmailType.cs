using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class EmailType : IHaveDefaultValues
    {
        public EmailType()
        {
        }

        public EmailType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

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

        public static implicit operator string(EmailType content)
        {
            return content.Content;
        }

        public static implicit operator EmailType(string n)
        {
            return new EmailType(n);
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

        public static EmailType operator +(EmailType content)
        {
            throw new Exception();
        }

        public static EmailType operator -(EmailType content)
        {
            throw new Exception();
        }

        public static EmailType operator !(EmailType content)
        {
            throw new Exception();
        }

        public static EmailType operator ~(EmailType content)
        {
            throw new Exception();
        }

        public static EmailType operator ++(EmailType content)
        {
            throw new Exception();
        }

        public static EmailType operator --(EmailType content)
        {
            throw new Exception();
        }

        public static bool operator true(EmailType content)
        {
            throw new Exception();
        }

        public static bool operator false(EmailType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static EmailType operator +(EmailType content, string n)
        {
            return content.Content + n;
        }

        public static EmailType operator -(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator *(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator /(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator %(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator &(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator |(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator ^(EmailType content, string n)
        {
            throw new Exception();
        }

        public static EmailType operator <<(EmailType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static EmailType operator >>(EmailType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(EmailType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(EmailType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(EmailType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(EmailType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(EmailType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(EmailType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (String.IsNullOrEmpty(type)) this.type = "Internet";
            }
        }
    }
}