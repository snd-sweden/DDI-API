using System;
namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public abstract class AbstractIdentifiableType
    {
        public AbstractIdentifiableType()
        {
            this.UserID = new System.Collections.Generic.List<UserIDType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public Nullable<ActionCodeType> action { get; set; }

        public bool ShouldSerializeaction()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "action")]
        public string actionValue
        {
            get
            {
                if (action.HasValue)
                    return action.ToString();
                return null;
            }
            set
            {
                ActionCodeType result;
                Enum.TryParse<ActionCodeType>(value, out result);
                action = result;
            }
        }

        public bool ShouldSerializeactionValue()
        {
            return this.action.HasValue;
        }

        private string _id;
        private static string idpattern = @"([A-Z]|[a-z]|\*|@|[0-9]|_|$|\-)*";

        [System.Xml.Serialization.XmlAttribute()]
        public string id
        {
            get
            {
                if (string.IsNullOrEmpty(this._id))
                    this._id = System.Guid.NewGuid().ToString();
                return this._id;
            }
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, idpattern))
                    throw new System.ArgumentException("value does not match pattern");
                else
                    this._id = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
        public string objectSource { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
        public string urn { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public System.Collections.Generic.List<UserIDType> UserID { get; set; }

        /// <summary>
        /// Gets or sets the type of the object. Used for URN generation.
        /// </summary>
        /// <value>
        /// The type of the object.
        /// </value>
        internal string ObjectType { get; set; }
    }
}