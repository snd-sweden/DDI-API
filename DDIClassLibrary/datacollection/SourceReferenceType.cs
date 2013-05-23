using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class SourceReferenceType : ReferenceType
    {
        public SourceReferenceType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Mnemonic { get; set; }
    }
}