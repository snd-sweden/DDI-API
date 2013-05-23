namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public abstract class AbstractMaintainableType : AbstractVersionableType, IHaveDefaultValues
    {
        public AbstractMaintainableType()
        {

        }

        [System.Xml.Serialization.XmlAttribute(DataType = "NCName")]
        public string agency { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
        public string externalReferenceDefaultURI { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPublished { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }
        
        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                isPublished = false;
            }
        }
    }
}