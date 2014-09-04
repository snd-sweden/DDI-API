using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class KindOfDataType : CodeValueType, IHaveDefaultValues
    {
        private Nullable<KindOfDataTypeType> _type;

        [System.Xml.Serialization.XmlAttribute()]
        public KindOfDataTypeType type
        {
            get
            {
                if (_type.HasValue)
                    return _type.Value;
                return KindOfDataTypeType.Quantitative; //default value;
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
        
        public KindOfDataType()
        {
        }

        public KindOfDataType(string content)
        {
            this.Content = content;
        }

        #region conversion

        public static implicit operator string(KindOfDataType content)
        {
            return content.Content;
        }

        public static implicit operator KindOfDataType(string n)
        {
            return new KindOfDataType(n);
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

        public static KindOfDataType operator +(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator -(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator !(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator ~(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator ++(KindOfDataType content)
        {
            throw new Exception();
        }

        public static KindOfDataType operator --(KindOfDataType content)
        {
            throw new Exception();
        }

        public static bool operator true(KindOfDataType content)
        {
            throw new Exception();
        }

        public static bool operator false(KindOfDataType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static KindOfDataType operator +(KindOfDataType content, string n)
        {
            return content.Content + n;
        }

        public static KindOfDataType operator -(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator *(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator /(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator %(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator &(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator |(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator ^(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static KindOfDataType operator <<(KindOfDataType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static KindOfDataType operator >>(KindOfDataType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(KindOfDataType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(KindOfDataType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(KindOfDataType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        /// <summary>
        /// Sets the default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c> [should set].</param>
        public override void SetDefaultValues(bool shouldSet)
        {
            base.SetDefaultValues(shouldSet);
            if (shouldSet)
                this.codeListVersionID = "1.0";
        }
    }
}