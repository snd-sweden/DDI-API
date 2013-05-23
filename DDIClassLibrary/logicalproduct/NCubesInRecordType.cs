using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class NCubesInRecordType
    {
        public NCubesInRecordType()
        {
            this.NCubeSchemeReference = new List<SchemeReferenceType>();
            this.NCubeReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public bool allNCubesInLogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public VariablesInRecordType VariablesInRecord { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<SchemeReferenceType> NCubeSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ReferenceType> NCubeReference { get; set; }
    }
}