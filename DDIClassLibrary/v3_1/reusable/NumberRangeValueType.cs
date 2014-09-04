using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class NumberRangeValueType : IHaveDefaultValues
    {
        public NumberRangeValueType()
        {

        }

        public NumberRangeValueType(double content)
        {
            this.Content = content;
        }

        private Nullable<bool> _included;

        [System.Xml.Serialization.XmlAttribute()]
        public bool included
        {
            get
            {
                if (_included.HasValue)
                    return _included.Value;
                return true; //default value;
            }
            set
            {
                this._included = value;
            }
        }

        public bool ShouldSerializeincluded()
        {
            return _included.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public double Content { get; set; }

        #region conversion

        public static implicit operator double(NumberRangeValueType content)
        {
            return content.Content;
        }

        public static implicit operator NumberRangeValueType(double n)
        {
            return new NumberRangeValueType(n);
        }

        public override bool Equals(object obj)
        {
            return this.Content == (double)obj;
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

        public static NumberRangeValueType operator +(NumberRangeValueType content, double n)
        {
            return content.Content + n;
        }

        public static NumberRangeValueType operator -(NumberRangeValueType content, double n)
        {
            return content.Content - n;
        }

        public static NumberRangeValueType operator *(NumberRangeValueType content, double n)
        {
            return content.Content * n;
        }

        public static NumberRangeValueType operator /(NumberRangeValueType content, double n)
        {
            return content.Content / n;
        }

        public static NumberRangeValueType operator %(NumberRangeValueType content, double n)
        {
            return content.Content % n;
        }

        public static NumberRangeValueType operator &(NumberRangeValueType content, double n)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator |(NumberRangeValueType content, double n)
        {
            throw new Exception();
        }

        public static NumberRangeValueType operator ^(NumberRangeValueType content, double n)
        {
            throw new Exception();
        }

        #endregion binary

        #region comparison

        public static bool operator ==(NumberRangeValueType content, double n)
        {
            return content.Content == n;
        }

        public static bool operator !=(NumberRangeValueType content, double n)
        {
            return content.Content != n;
        }

        public static bool operator <(NumberRangeValueType content, double n)
        {
            return content.Content < n;
        }

        public static bool operator >(NumberRangeValueType content, double n)
        {
            return content.Content > n;
        }

        public static bool operator <=(NumberRangeValueType content, double n)
        {
            return content.Content <= n;
        }

        public static bool operator >=(NumberRangeValueType content, double n)
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
                if (!_included.HasValue) _included = true;
            }
        }
    }
}