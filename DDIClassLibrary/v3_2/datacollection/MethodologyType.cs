using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class MethodologyType : VersionableType
    {
        public MethodologyType()
        {
            this.DataCollectionMethodology = new List<DataCollectionMethodologyType>();
            this.TimeMethod = new List<TimeMethodType>();
            this.SamplingProcedure = new List<SamplingProcedureType>();
            this.DeviationFromSampleDesign = new List<DeviationFromSampleDesignType>();
            this.DataCollectionSoftware = new List<SoftwareType>();
            this.QualityStatementReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<DataCollectionMethodologyType> DataCollectionMethodology { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<TimeMethodType> TimeMethod { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<SamplingProcedureType> SamplingProcedure { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DeviationFromSampleDesignType> DeviationFromSampleDesign { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<SoftwareType> DataCollectionSoftware { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> QualityStatementReference { get; set; }
    }
}