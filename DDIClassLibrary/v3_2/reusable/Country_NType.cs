using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class Country_NType : CountryCodeType
    {
        public Country_NType()
        {
            this.codeListID = "ISO3166_numeric";
            this.codeListName = "ISO3166 numeric";
            this.codeListAgencyName = "DDI Alliance";
            this.codeListURN = "urn:ddi-cv:ISO3166_numeric";
        }

        public Country_NType(string content)
        {
            this.Content = content;

            this.codeListID = "ISO3166_numeric";
            this.codeListName = "ISO3166 numeric";
            this.codeListAgencyName = "DDI Alliance";
            this.codeListURN = "urn:ddi-cv:ISO3166_numeric";
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

        public static implicit operator string(Country_NType content)
        {
            return content.Content;
        }

        public static implicit operator Country_NType(string n)
        {
            return new Country_NType(n);
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

        public static Country_NType operator +(Country_NType content)
        {
            throw new Exception();
        }

        public static Country_NType operator -(Country_NType content)
        {
            throw new Exception();
        }

        public static Country_NType operator !(Country_NType content)
        {
            throw new Exception();
        }

        public static Country_NType operator ~(Country_NType content)
        {
            throw new Exception();
        }

        public static Country_NType operator ++(Country_NType content)
        {
            throw new Exception();
        }

        public static Country_NType operator --(Country_NType content)
        {
            throw new Exception();
        }

        public static bool operator true(Country_NType content)
        {
            throw new Exception();
        }

        public static bool operator false(Country_NType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static Country_NType operator +(Country_NType content, string n)
        {
            return content.Content + n;
        }

        public static Country_NType operator -(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator *(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator /(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator %(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator &(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator |(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator ^(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static Country_NType operator <<(Country_NType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static Country_NType operator >>(Country_NType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(Country_NType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(Country_NType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(Country_NType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(Country_NType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}