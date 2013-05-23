using System;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class ValueType : IHaveDefaultValues
    {
        public ValueType()
        {

        }

        public ValueType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public Nullable<ValueTypeCodeType> type { get; set; }

        public bool ShouldSerializetype()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "type")]
        public string typeValue
        {
            get
            {
                if (type.HasValue)
                    return type.ToString();
                return null;
            }
            set
            {
                ValueTypeCodeType result;
                Enum.TryParse<ValueTypeCodeType>(value, out result);
                type = result;
            }
        }

        public bool ShouldSerializetypeValue()
        {
            return this.type.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(ValueType content)
        {
            return content.Content;
        }

        public static implicit operator ValueType(string n)
        {
            return new ValueType(n);
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

        public static ValueType operator +(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator -(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator !(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator ~(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator ++(ValueType content)
        {
            throw new Exception();
        }

        public static ValueType operator --(ValueType content)
        {
            throw new Exception();
        }

        public static bool operator true(ValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(ValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ValueType operator +(ValueType content, string n)
        {
            return content.Content + n;
        }

        public static ValueType operator -(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator *(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator /(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator %(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator &(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator |(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator ^(ValueType content, string n)
        {
            throw new Exception();
        }

        public static ValueType operator <<(ValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ValueType operator >>(ValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ValueType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ValueType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ValueType content, string n)
        {
            throw new Exception();
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
                if (!this.type.HasValue) this.type = ValueTypeCodeType.Equal;
            }
        }
    }
}