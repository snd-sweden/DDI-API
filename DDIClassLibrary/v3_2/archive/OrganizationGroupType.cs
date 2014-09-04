using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.archive
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:archive:3_2")]
    public class OrganizationGroupType : VersionableType
    {
        public OrganizationGroupType()
        {
            this.OrganizationGroupName = new List<NameType>();
            this.Label = new List<LabelType>();
            this.UniverseReference = new List<ReferenceType>();
            this.Subject = new List<InternationalCodeValueType>();
            this.Keyword = new List<InternationalCodeValueType>();
            this.OrganizationReference = new List<InternationalCodeValueType>();
            this.IndividualReference = new List<InternationalCodeValueType>();
            this.RelationReference = new List<InternationalCodeValueType>();
            this.OrganizationGroupReference = new List<InternationalCodeValueType>();
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

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeValueType TypeOfOrganizationGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<NameType> OrganizationGroupName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<LabelType> Label { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 5)]
        public ReferenceType ConceptReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<InternationalCodeValueType> Subject { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<InternationalCodeValueType> Keyword { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<InternationalCodeValueType> OrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<InternationalCodeValueType> IndividualReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<InternationalCodeValueType> RelationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<InternationalCodeValueType> OrganizationGroupReference { get; set; }

    }
}