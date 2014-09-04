namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class FingerprintType
    {
        public FingerprintType()
        {
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string Value { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string AlgorithmSpecification { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string AlgorithmVersion { get; set; }
    }
}