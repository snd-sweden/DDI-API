using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_2")]
    public class RecordLayoutType : BaseRecordLayoutType
    {
        public RecordLayoutType()
        {            
            this.NCubeInstance = new List<NCubeInstanceType>();
            this.NCubeInstanceReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CodeValueType CharacterSet { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public Nullable<int> ArrayBase { get; set; }

        public bool ShouldSerializeArrayBase()
        {
            return ArrayBase.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<NCubeInstanceType> NCubeInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<ReferenceType> NCubeInstanceReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public TopLeftTableAnchorType TopLeftTableAnchor { get; set; }

    }
}