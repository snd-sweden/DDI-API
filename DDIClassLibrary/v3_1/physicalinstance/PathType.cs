using System;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class PathType : IHaveDefaultValues
    {
        public PathType()
        {

        }

        public PathType(string content)
        {
            this.Content = content;
        }

        private Nullable<bool> _isPublic;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPublic
        {
            get
            {
                if (_isPublic.HasValue)
                    return _isPublic.Value;
                return true; //default value;
            }
            set
            {
                this._isPublic = value;
            }
        }

        public bool ShouldSerializeisPublic()
        {
            return _isPublic.HasValue;
        }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(PathType content)
        {
            return content.Content;
        }

        public static implicit operator PathType(string n)
        {
            return new PathType(n);
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

        public static PathType operator +(PathType content)
        {
            throw new Exception();
        }

        public static PathType operator -(PathType content)
        {
            throw new Exception();
        }

        public static PathType operator !(PathType content)
        {
            throw new Exception();
        }

        public static PathType operator ~(PathType content)
        {
            throw new Exception();
        }

        public static PathType operator ++(PathType content)
        {
            throw new Exception();
        }

        public static PathType operator --(PathType content)
        {
            throw new Exception();
        }

        public static bool operator true(PathType content)
        {
            throw new Exception();
        }

        public static bool operator false(PathType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static PathType operator +(PathType content, string n)
        {
            return content.Content + n;
        }

        public static PathType operator -(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator *(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator /(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator %(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator &(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator |(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator ^(PathType content, string n)
        {
            throw new Exception();
        }

        public static PathType operator <<(PathType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static PathType operator >>(PathType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(PathType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(PathType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(PathType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(PathType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(PathType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(PathType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isPublic.HasValue) this._isPublic = true;
            }
        }
    }
}