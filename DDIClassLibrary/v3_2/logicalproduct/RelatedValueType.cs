using System;
namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class RelatedValueType : IHaveDefaultValues
    {
        public RelatedValueType()
        {
        }

        public RelatedValueType(string content)
        {
            this.Content = content;
        }

        private Nullable<RelatedValueTypeCodeType> _type;

        [System.Xml.Serialization.XmlAttribute()]
        public RelatedValueTypeCodeType type
        {
            get
            {
                if (_type.HasValue)
                    return _type.Value;
                return RelatedValueTypeCodeType.Equal; //default value;
            }
            set
            {
                this._type = value;
            }
        }

        public bool ShouldSerializetype()
        {
            return _type.HasValue;
        }

        private Nullable<bool> _valueIsBlank;

        [System.Xml.Serialization.XmlAttribute()]
        public bool valueIsBlank
        {
            get
            {
                if (_valueIsBlank.HasValue)
                    return _valueIsBlank.Value;
                return false; //default value;
            }
            set
            {
                this._valueIsBlank = value;
            }
        }

        public bool ShouldSerializevalueIsBlank()
        {
            return _valueIsBlank.HasValue;
        }
        
        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(RelatedValueType content)
        {
            return content.Content;
        }

        public static implicit operator RelatedValueType(string n)
        {
            return new RelatedValueType(n);
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

        public static RelatedValueType operator +(RelatedValueType content)
        {
            throw new Exception();
        }

        public static RelatedValueType operator -(RelatedValueType content)
        {
            throw new Exception();
        }

        public static RelatedValueType operator !(RelatedValueType content)
        {
            throw new Exception();
        }

        public static RelatedValueType operator ~(RelatedValueType content)
        {
            throw new Exception();
        }

        public static RelatedValueType operator ++(RelatedValueType content)
        {
            throw new Exception();
        }

        public static RelatedValueType operator --(RelatedValueType content)
        {
            throw new Exception();
        }

        public static bool operator true(RelatedValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(RelatedValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static RelatedValueType operator +(RelatedValueType content, string n)
        {
            return content.Content + n;
        }

        public static RelatedValueType operator -(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator *(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator /(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator %(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator &(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator |(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator ^(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static RelatedValueType operator <<(RelatedValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static RelatedValueType operator >>(RelatedValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(RelatedValueType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(RelatedValueType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(RelatedValueType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        public void SetDefaultValues(bool shouldSet)
        {
            if(shouldSet)
            {
                if (!_type.HasValue) this.type = RelatedValueTypeCodeType.Equal;
                if (!this._valueIsBlank.HasValue) this._valueIsBlank = false;
            }
        }
    }
}