namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public abstract class AbstractVersionableType : AbstractIdentifiableType
    {
        public AbstractVersionableType()
        {
            this.VersionRationale = new System.Collections.Generic.List<InternationalStringType>();
        }

        private string _version;
        private static string versionpattern = @"(([0-9\*]+\.[0-9\*]+\.[0-9\*]+)|([0-9\*]+\.[0-9\*]+\.L)|([0-9\*]+\.L\.L)|(L\.L\.L))";

        [System.Xml.Serialization.XmlAttribute()]
        public string version
        {
            get
            {
                if (string.IsNullOrEmpty(this._version))
                    this._version = "1.0.0";
                return this._version;
            }
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, versionpattern))
                    throw new System.ArgumentException("value does not match pattern");
                else
                    this._version = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string versionDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string VersionResponsibility { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public System.Collections.Generic.List<InternationalStringType> VersionRationale { get; set; }
    }
}