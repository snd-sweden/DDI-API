using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class VariablesInRecordType
    {
        public VariablesInRecordType()
        {
            this.VariableSchemeReference = new List<SchemeReferenceType>();
            this.VariableUsedReference = new List<ReferenceType>();
        }

        private Nullable<bool> _allVariablesInLogicalProduct;

        [System.Xml.Serialization.XmlAttribute()]
        public bool allVariablesInLogicalProduct
        {
            get
            {
                if (_allVariablesInLogicalProduct.HasValue)
                    return _allVariablesInLogicalProduct.Value;
                return false; //default value;
            }
            set
            {
                this._allVariablesInLogicalProduct = value;
            }
        }

        public bool ShouldSerializeallVariablesInLogicalProduct()
        {
            return _allVariablesInLogicalProduct.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 0)]
        public List<SchemeReferenceType> VariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<ReferenceType> VariableUsedReference { get; set; }
    }
}