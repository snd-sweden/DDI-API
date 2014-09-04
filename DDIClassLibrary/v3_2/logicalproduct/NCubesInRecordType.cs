using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class NCubesInRecordType
    {
        public NCubesInRecordType()
        {
            this.NCubeSchemeReference = new List<SchemeReferenceType>();
            this.NCubeReference = new List<ReferenceType>();
        }

        private Nullable<bool> _allNCubesInLogicalProduct;

        [System.Xml.Serialization.XmlAttribute()]
        public bool allNCubesInLogicalProduct
        {
            get
            {
                if (_allNCubesInLogicalProduct.HasValue)
                    return _allNCubesInLogicalProduct.Value;
                return false; //default value;
            }
            set
            {
                this._allNCubesInLogicalProduct = value;
            }
        }

        public bool ShouldSerializeallNCubesInLogicalProduct()
        {
            return _allNCubesInLogicalProduct.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public VariablesInRecordType VariablesInRecord { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<SchemeReferenceType> NCubeSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<ReferenceType> NCubeReference { get; set; }
    }
}