using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_proprietary
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_proprietary:3_2")]
    public class DataItemType
    {
        public DataItemType()
        {
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public ReferenceType VariableReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType ProprietaryDataType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType ProprietaryOutputFormat { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ProprietaryInfoType ProprietaryInfo { get; set; }
    }
}