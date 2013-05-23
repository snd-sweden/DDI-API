using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ContributorType : InternationalStringType
    {
        public ContributorType()
        {
        }

        public ContributorType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string affiliation { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string role { get; set; }

        #region conversion

        public static implicit operator string(ContributorType content)
        {
            return content.Content;
        }

        public static implicit operator ContributorType(string n)
        {
            return new ContributorType(n);
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

        public static ContributorType operator +(ContributorType content)
        {
            throw new Exception();
        }

        public static ContributorType operator -(ContributorType content)
        {
            throw new Exception();
        }

        public static ContributorType operator !(ContributorType content)
        {
            throw new Exception();
        }

        public static ContributorType operator ~(ContributorType content)
        {
            throw new Exception();
        }

        public static ContributorType operator ++(ContributorType content)
        {
            throw new Exception();
        }

        public static ContributorType operator --(ContributorType content)
        {
            throw new Exception();
        }

        public static bool operator true(ContributorType content)
        {
            throw new Exception();
        }

        public static bool operator false(ContributorType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ContributorType operator +(ContributorType content, string n)
        {
            return content.Content + n;
        }

        public static ContributorType operator -(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator *(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator /(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator %(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator &(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator |(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator ^(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static ContributorType operator <<(ContributorType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ContributorType operator >>(ContributorType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ContributorType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ContributorType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ContributorType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ContributorType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}