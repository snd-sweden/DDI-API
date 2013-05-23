using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class DataAppraisalInformationType
    {
        public DataAppraisalInformationType()
        {
            this.ResponseRate = new List<string>();
            this.SamplingError = new List<StructuredStringType>();
            this.OtherAppraisalProcess = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<string> ResponseRate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> SamplingError { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> OtherAppraisalProcess { get; set; }
    }
}