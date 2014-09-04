using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class DataAppraisalInformationType
    {
        public DataAppraisalInformationType()
        {
            this.ResponseRate = new List<ResponseRateType>();
            this.SamplingError = new List<StructuredStringType>();
            this.OtherAppraisalProcess = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ResponseRateType> ResponseRate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<StructuredStringType> SamplingError { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> OtherAppraisalProcess { get; set; }
    }
}