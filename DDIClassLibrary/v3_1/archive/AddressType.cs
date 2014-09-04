using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_1")]
    public class AddressType
    {
        public AddressType()
        {
        }

        public AddressType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "NMTOKENS")]
        public string vcardType { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<string> Line { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string City { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string State { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string Postal { get; set; }

        #region conversion

        public static implicit operator string(AddressType content)
        {
            return content.Content;
        }

        public static implicit operator AddressType(string n)
        {
            return new AddressType(n);
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

        public static AddressType operator +(AddressType content)
        {
            throw new Exception();
        }

        public static AddressType operator -(AddressType content)
        {
            throw new Exception();
        }

        public static AddressType operator !(AddressType content)
        {
            throw new Exception();
        }

        public static AddressType operator ~(AddressType content)
        {
            throw new Exception();
        }

        public static AddressType operator ++(AddressType content)
        {
            throw new Exception();
        }

        public static AddressType operator --(AddressType content)
        {
            throw new Exception();
        }

        public static bool operator true(AddressType content)
        {
            throw new Exception();
        }

        public static bool operator false(AddressType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static AddressType operator +(AddressType content, string n)
        {
            return content.Content + n;
        }

        public static AddressType operator -(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator *(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator /(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator %(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator &(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator |(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator ^(AddressType content, string n)
        {
            throw new Exception();
        }

        public static AddressType operator <<(AddressType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static AddressType operator >>(AddressType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(AddressType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(AddressType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(AddressType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(AddressType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(AddressType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(AddressType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}