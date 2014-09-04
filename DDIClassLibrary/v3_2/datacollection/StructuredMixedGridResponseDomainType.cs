using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class StructuredMixedGridResponseDomainType
    {
        public StructuredMixedGridResponseDomainType()
        {
            this.GridResponseDomain = new List<GridResponseDomainType>();
            this.NoDataByDefinition = new List<GridAttachmentType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<GridResponseDomainType> GridResponseDomain { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<GridAttachmentType> NoDataByDefinition { get; set; }

    }
}