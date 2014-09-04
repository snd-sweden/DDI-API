using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class AddressType
    {
        public AddressType()
        {
            this.Line = new List<string>();
        }

        public AddressType(string content)
        {
            this.Content = content;
            this.Line = new List<string>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string privacy { get; set; }
        
        private Nullable<bool> _isPreferred;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPreferred
        {
            get
            {
                if (_isPreferred.HasValue)
                    return _isPreferred.Value;
                return false; //default value;
            }
            set
            {
                this._isPreferred = value;
            }
        }

        public bool ShouldSerializeisPreferred()
        {
            return _isPreferred.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfAddress { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<string> Line { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string CityPlaceLocal { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string StateProvince { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string PostalCode { get; set; }

        [System.Xml.Serialization.XmlElement("Country", typeof(CountryType), Namespace = "ddi:reusable:3_2", Order = 5)]
        [System.Xml.Serialization.XmlElement("Country_2", typeof(Country_2Type), Namespace = "ddi:reusable:3_2", Order = 5)]
        [System.Xml.Serialization.XmlElement("Country_3", typeof(Country_3Type), Namespace = "ddi:reusable:3_2", Order = 5)]
        [System.Xml.Serialization.XmlElement("Country_N", typeof(Country_NType), Namespace = "ddi:reusable:3_2", Order = 5)]
        public CountryCodeType CountryCode { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public PointType GeographicPoint { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 7)]
        public CodeValueType TimeZone { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 8)]
        public DateType EffectivePeriod { get; set; }

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