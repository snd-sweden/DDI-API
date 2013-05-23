using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class TemporalCoverageType : IdentifiableType
    {
        public TemporalCoverageType()
        {
            this.ObjectType = "TemporalCoverage";

            this.ReferenceDate = new List<DateType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<DateType> ReferenceDate { get; set; }
    }
}