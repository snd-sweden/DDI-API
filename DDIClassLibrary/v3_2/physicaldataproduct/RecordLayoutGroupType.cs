﻿using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.physicaldataproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct:3_2")]
    public class RecordLayoutGroupType : VersionableType, IHaveDefaultValues
    {
        public RecordLayoutGroupType()
        {
            this.RecordLayoutGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.UniverseReference = new List<ReferenceType>();
            this.Subject = new List<InternationalCodeValueType>();
            this.Keyword = new List<InternationalCodeValueType>();
            this.RecordLayoutReference = new List<ReferenceType>();
            this.RecordLayoutGroupReference = new List<ReferenceType>();
        }

        private Nullable<bool> _isOrdered;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isOrdered
        {
            get
            {
                if (_isOrdered.HasValue)
                    return _isOrdered.Value;
                return false; //default value;
            }
            set
            {
                this._isOrdered = value;
            }
        }

        public bool ShouldSerializeisOrdered()
        {
            return _isOrdered.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<NameType> RecordLayoutGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 1)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 2)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<InternationalCodeValueType> Subject { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<ReferenceType> RecordLayoutReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<ReferenceType> RecordLayoutGroupReference { get; set; }
    }
}