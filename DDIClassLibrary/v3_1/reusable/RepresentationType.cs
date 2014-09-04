using System;
namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class RepresentationType
    {
        public RepresentationType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public bool blankIsMissingValue { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public Nullable<CategoryRelationCodeType> classificationLevel { get; set; }

        public bool ShouldSerializeclassificationLevel()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "classificationLevel")]
        public string classificationLevelValue
        {
            get
            {
                if (classificationLevel.HasValue)
                    return classificationLevel.ToString();
                return null;
            }
            set
            {
                CategoryRelationCodeType result;
                Enum.TryParse<CategoryRelationCodeType>(value, out result);
                classificationLevel = result;
            }
        }

        public bool ShouldSerializeclassificationLevelValue()
        {
            return this.classificationLevel.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "NMTOKENS")]
        public string missingValue { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType RecommendedDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType GenericOutputFormat { get; set; }
    }
}