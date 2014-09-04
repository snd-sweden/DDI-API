using System;

namespace DDIClassLibrary.v3_2.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_2")]
    public class StatisticType
    {
        public StatisticType()
        {

        }

        public StatisticType(decimal content)
        {
            this.Content = content;
        }

        private Nullable<bool> _isWeighted;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isWeighted
        {
            get
            {
                if (_isWeighted.HasValue)
                    return _isWeighted.Value;
                return false; //default value;
            }
            set
            {
                this._isWeighted = value;
            }
        }

        public bool ShouldSerializeisWeighted()
        {
            return _isWeighted.HasValue;
        }

        private Nullable<ComputationBaseType> _computationBase;

        [System.Xml.Serialization.XmlAttribute()]
        public ComputationBaseType computationBase
        {
            get
            {
                if (_computationBase.HasValue)
                    return _computationBase.Value;
                return 0; //default value;
            }
            set
            {
                this._computationBase = value;
            }
        }

        public bool ShouldSerializecomputationBase()
        {
            return _computationBase.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public decimal Content { get; set; }

        #region conversion

        public static implicit operator decimal(StatisticType content)
        {
            return content.Content;
        }

        public static implicit operator StatisticType(decimal n)
        {
            return new StatisticType(n);
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

        public static StatisticType operator +(StatisticType content)
        {
            throw new Exception();
        }

        public static StatisticType operator -(StatisticType content)
        {
            throw new Exception();
        }

        public static StatisticType operator !(StatisticType content)
        {
            throw new Exception();
        }

        public static StatisticType operator ~(StatisticType content)
        {
            throw new Exception();
        }

        public static StatisticType operator ++(StatisticType content)
        {
            throw new Exception();
        }

        public static StatisticType operator --(StatisticType content)
        {
            throw new Exception();
        }

        public static bool operator true(StatisticType content)
        {
            throw new Exception();
        }

        public static bool operator false(StatisticType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static StatisticType operator +(StatisticType content, decimal n)
        {
            return content.Content + n;
        }

        public static StatisticType operator -(StatisticType content, decimal n)
        {
            return content.Content - n;
        }

        public static StatisticType operator *(StatisticType content, decimal n)
        {
            return content.Content * n;
        }

        public static StatisticType operator /(StatisticType content, decimal n)
        {
            return content.Content / n;
        }

        public static StatisticType operator %(StatisticType content, decimal n)
        {
            return content.Content % n;
        }

        public static StatisticType operator &(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        public static StatisticType operator |(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        public static StatisticType operator ^(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        public static StatisticType operator <<(StatisticType content, int n)
        {
            throw new Exception();
        }

        public static StatisticType operator >>(StatisticType content, int n)
        {
            throw new Exception();
        }

        #endregion binary

        #region comparison

        public static bool operator ==(StatisticType content, decimal n)
        {
            return content.Content == n;
        }

        public static bool operator !=(StatisticType content, decimal n)
        {
            return content.Content != n;
        }

        public static bool operator <(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        public static bool operator >(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        public static bool operator <=(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        public static bool operator >=(StatisticType content, decimal n)
        {
            throw new Exception();
        }

        #endregion comparison

    }
}