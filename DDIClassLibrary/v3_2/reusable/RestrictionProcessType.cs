namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RestrictionProcessType
    {
        public RestrictionProcessType()
        {

        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ProcessingInstructionReferenceType ProcessingInstructionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CommandCodeType CommandCode { get; set; }

    }
}
