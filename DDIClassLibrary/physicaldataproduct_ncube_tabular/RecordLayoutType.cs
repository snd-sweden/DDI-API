using System.Collections.Generic;
using DDIClassLibrary.physicaldataproduct;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_1")]
    public class RecordLayoutType : BaseRecordLayoutType
    {
        public RecordLayoutType()
        {
            this.ObjectType = "RecordLayout";
            
            this.NCubeInstance = new List<NCubeInstanceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType CharacterSet { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public int ArrayBase { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<NCubeInstanceType> NCubeInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public TopLeftTableAnchorType TopLeftTableAnchor { get; set; }
    }
}