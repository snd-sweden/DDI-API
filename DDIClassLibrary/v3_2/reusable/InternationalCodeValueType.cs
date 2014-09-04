using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class InternationalCodeValueType : StringType, IHaveDefaultValues
    {
        public InternationalCodeValueType()
        {

        }

        public InternationalCodeValueType(string content)
        {
            this.Content = content;
        }
        

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListID { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListName { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListAgencyName { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListVersionID { get; set; }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string otherValue { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListURN { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string codeListSchemeURN { get; set; }
        
        #region conversion

        public static implicit operator string(InternationalCodeValueType content)
        {
            return content.Content;
        }

        public static implicit operator InternationalCodeValueType(string n)
        {
            return new InternationalCodeValueType(n);
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

        public static InternationalCodeValueType operator +(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator -(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator !(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator ~(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator ++(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator --(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static bool operator true(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        public static bool operator false(InternationalCodeValueType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static InternationalCodeValueType operator +(InternationalCodeValueType content, string n)
        {
            return content.Content + n;
        }

        public static InternationalCodeValueType operator -(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator *(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator /(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator %(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator &(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator |(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator ^(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static InternationalCodeValueType operator <<(InternationalCodeValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static InternationalCodeValueType operator >>(InternationalCodeValueType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(InternationalCodeValueType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(InternationalCodeValueType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(InternationalCodeValueType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (String.IsNullOrEmpty(this.codeListVersionID)) this.codeListVersionID = "1.0";
            }
        }
    }
}