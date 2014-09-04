using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ContentDateOffsetType : CodeValueType, IHaveDefaultValues
    {

        public ContentDateOffsetType()
        {
        }

        public ContentDateOffsetType(string content)
        {
            this.Content = content;
        }

        private Nullable<decimal> _numberOfUnits;

        [System.Xml.Serialization.XmlAttribute()]
        public decimal numberOfUnits
        {
            get
            {
                if (_numberOfUnits.HasValue)
                    return _numberOfUnits.Value;
                return 0; //default value;
            }
            set
            {
                this._numberOfUnits = value;
            }
        }

        public bool ShouldSerializenumberOfUnits()
        {
            return _numberOfUnits.HasValue;
        }

        private Nullable<bool> _isNegativeOffset;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isNegativeOffset
        {
            get
            {
                if (_isNegativeOffset.HasValue)
                    return _isNegativeOffset.Value;
                return true; //default value;
            }
            set
            {
                this._isNegativeOffset = value;
            }
        }

        public bool ShouldSerializeisNegativeOffset()
        {
            return _isNegativeOffset.HasValue;
        }

        #region conversion

        public static implicit operator string(ContentDateOffsetType content)
        {
            return content.Content;
        }

        public static implicit operator ContentDateOffsetType(string n)
        {
            return new ContentDateOffsetType(n);
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

        public static ContentDateOffsetType operator +(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator -(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator !(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator ~(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator ++(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator --(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static bool operator true(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        public static bool operator false(ContentDateOffsetType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ContentDateOffsetType operator +(ContentDateOffsetType content, string n)
        {
            return content.Content + n;
        }

        public static ContentDateOffsetType operator -(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator *(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator /(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator %(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator &(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator |(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator ^(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static ContentDateOffsetType operator <<(ContentDateOffsetType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ContentDateOffsetType operator >>(ContentDateOffsetType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ContentDateOffsetType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ContentDateOffsetType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ContentDateOffsetType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        public override void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if (shouldSet)
            {
                if (!_isNegativeOffset.HasValue) _isNegativeOffset = true;
            }
        }
    }
}