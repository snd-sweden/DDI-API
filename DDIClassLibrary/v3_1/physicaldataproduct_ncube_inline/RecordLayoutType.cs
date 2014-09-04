using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.physicaldataproduct;

namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_inline
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_inline:3_1")]
    public class RecordLayoutType : BaseRecordLayoutType
    {
        public RecordLayoutType()
        {
            this.ObjectType = "RecordLayout";
            
            this.NCubeInstance = new List<NCubeInstanceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public Nullable<int> ArrayBase { get; set; }

        public bool ShouldSerializeArrayBase()
        {
            return ArrayBase.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<NCubeInstanceType> NCubeInstance { get; set; }
    }
}