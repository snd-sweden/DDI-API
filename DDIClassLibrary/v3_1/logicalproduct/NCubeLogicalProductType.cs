using System.Collections.Generic;

namespace DDIClassLibrary.v3_1.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class NCubeLogicalProductType : BaseLogicalProductType
    {
        public NCubeLogicalProductType()
        {
            this.NCubeScheme = new List<NCubeSchemeType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<NCubeSchemeType> NCubeScheme { get; set; }
    }
}