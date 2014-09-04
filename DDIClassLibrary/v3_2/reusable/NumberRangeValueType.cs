using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class NumberRangeValueType : IHaveDefaultValues
    {
        public NumberRangeValueType()
        {

        }

        public NumberRangeValueType(decimal content)
        {
            this.Content = content;
        }

        private Nullable<bool> _isInclusive;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isInclusive
        {
            get
            {
                if (_isInclusive.HasValue)
                    return _isInclusive.Value;
                return true; //default value;
            }
            set
            {
                this._isInclusive = value;
            }
        }

        public bool ShouldSerializeisInclusive()
        {
            return _isInclusive.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public decimal Content { get; set; }

        #region conversion

        public static implicit operator decimal(NumberRangeValueType content)
        {
            return content.Content;
        }

        public static implicit operator NumberRangeValueType(decimal n)
        {
            return new NumberRangeValueType(n);
        }

        public override bool Equals(object obj)
        {
            return this.Content == (decimal)obj;
        }

        public override int GetHashCode()
        {
            return this.Content.GetHashCode();
        }

        #endregion conversion

        #region unary

        public static NumberRangeValueType operator +(NumberRangeValueType content)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator -(NumberRangeValueType content)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator !(NumberRangeValueType content)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator ~(NumberRangeValueType content)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator ++(NumberRangeValueType content)
        {
            return content++;
        }

        public static NumberRangeValueType operator --(NumberRangeValueType content)
        {
            return content--;
        }

        public static bool operator true(NumberRangeValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(NumberRangeValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static NumberRangeValueType operator +(NumberRangeValueType content, decimal n)
        {
            return content.Content + n;
        }

        public static NumberRangeValueType operator -(NumberRangeValueType content, decimal n)
        {
            return content.Content - n;
        }

        public static NumberRangeValueType operator *(NumberRangeValueType content, decimal n)
        {
            return content.Content * n;
        }

        public static NumberRangeValueType operator /(NumberRangeValueType content, decimal n)
        {
            return content.Content / n;
        }

        public static NumberRangeValueType operator %(NumberRangeValueType content, decimal n)
        {
            return content.Content % n;
        }

        public static NumberRangeValueType operator &(NumberRangeValueType content, decimal n)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator |(NumberRangeValueType content, decimal n)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator ^(NumberRangeValueType content, decimal n)
        {
            throw new Exception();
        }

        #endregion binary

        #region comparison

        public static bool operator ==(NumberRangeValueType content, decimal n)
        {
            return content.Content == n;
        }

        public static bool operator !=(NumberRangeValueType content, decimal n)
        {
            return content.Content != n;
        }

        public static bool operator <(NumberRangeValueType content, decimal n)
        {
            return content.Content < n;
        }

        public static bool operator >(NumberRangeValueType content, decimal n)
        {
            return content.Content > n;
        }

        public static bool operator <=(NumberRangeValueType content, decimal n)
        {
            return content.Content <= n;
        }

        public static bool operator >=(NumberRangeValueType content, decimal n)
        {
            return content.Content >= n;
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
                if (!_isInclusive.HasValue) _isInclusive = true;
            }
        }
    }
}