using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.physicaldataproduct;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_normal
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_normal:3_1")]
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
        public Nullable<int> ArrayBase { get; set; }

        public bool ShouldSerializeArrayBase()
        {
            return ArrayBase.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public List<NCubeInstanceType> NCubeInstance { get; set; }
    }
}