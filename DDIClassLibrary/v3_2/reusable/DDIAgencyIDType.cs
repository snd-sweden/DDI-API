using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class DDIAgencyIDType
    {
        public DDIAgencyIDType()
        {
        }

        public DDIAgencyIDType(string content)
        {
            this.Content = content;
        }

        private string _content;
        private static string pattern = @"[a-zA-Z0-9\-]{1,63}(\.[a-zA-Z0-9\-]{1,63})*";

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

        public static implicit operator string(DDIAgencyIDType content)
        {
            return content.Content;
        }

        public static implicit operator DDIAgencyIDType(string n)
        {
            return new DDIAgencyIDType(n);
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

        public static DDIAgencyIDType operator +(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator -(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator !(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator ~(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator ++(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator --(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static bool operator true(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        public static bool operator false(DDIAgencyIDType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static DDIAgencyIDType operator +(DDIAgencyIDType content, string n)
        {
            return content.Content + n;
        }

        public static DDIAgencyIDType operator -(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator *(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator /(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator %(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator &(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator |(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator ^(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIAgencyIDType operator <<(DDIAgencyIDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static DDIAgencyIDType operator >>(DDIAgencyIDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(DDIAgencyIDType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(DDIAgencyIDType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(DDIAgencyIDType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}