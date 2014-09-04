using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class Country_3Type : CountryCodeType
    {
        public Country_3Type()
        {
            this.codeListID = "ISO3166_3ch";
            this.codeListName = "ISO3166 3-letter";
            this.codeListAgencyName = "DDI Alliance";
            this.codeListURN = "urn:ddi-cv:ISO3166_3ch";
        }

        public Country_3Type(string content)
        {
            this.Content = content;

            this.codeListID = "ISO3166_3ch";
            this.codeListName = "ISO3166 3-letter";
            this.codeListAgencyName = "DDI Alliance";
            this.codeListURN = "urn:ddi-cv:ISO3166_3ch";
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListID { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListName { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListAgencyName { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string otherValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListURN { get; set; }

        #region conversion

        public static implicit operator string(Country_3Type content)
        {
            return content.Content;
        }

        public static implicit operator Country_3Type(string n)
        {
            return new Country_3Type(n);
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

        public static Country_3Type operator +(Country_3Type content)
        {
            throw new Exception();
        }

        public static Country_3Type operator -(Country_3Type content)
        {
            throw new Exception();
        }

        public static Country_3Type operator !(Country_3Type content)
        {
            throw new Exception();
        }

        public static Country_3Type operator ~(Country_3Type content)
        {
            throw new Exception();
        }

        public static Country_3Type operator ++(Country_3Type content)
        {
            throw new Exception();
        }

        public static Country_3Type operator --(Country_3Type content)
        {
            throw new Exception();
        }

        public static bool operator true(Country_3Type content)
        {
            throw new Exception();
        }

        public static bool operator false(Country_3Type content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static Country_3Type operator +(Country_3Type content, string n)
        {
            return content.Content + n;
        }

        public static Country_3Type operator -(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator *(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator /(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator %(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator &(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator |(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator ^(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static Country_3Type operator <<(Country_3Type content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static Country_3Type operator >>(Country_3Type content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(Country_3Type content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(Country_3Type content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(Country_3Type content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(Country_3Type content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}