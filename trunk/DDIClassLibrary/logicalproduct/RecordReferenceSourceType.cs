namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class RecordReferenceSourceType : VariableValueReferenceType
    {
        public RecordReferenceSourceType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public RelationCodeType relation { get; set; }
    }
}