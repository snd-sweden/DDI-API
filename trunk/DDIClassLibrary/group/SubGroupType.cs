using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DDIClassLibrary.archive;
using DDIClassLibrary.comparative;
using DDIClassLibrary.ddiprofile;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class SubGroupType : MaintainableType, IHaveDefaultValues
    {
        public SubGroupType()
        {
            this.ObjectType = "SubGroup";

            this.Abstract = new ObservableCollection<IdentifiedStructuredStringType>();
            this.Purpose = new ObservableCollection<IdentifiedStructuredStringType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.Concepts = new List<ConceptType>();
            this.DataCollection = new List<DataCollectionType>();
            this.LogicalProduct = new List<LogicalProductType>();
            this.PhysicalDataProduct = new List<PhysicalDataProductType>();
            this.DDIProfile = new List<DDIProfileType>();
            this.DDIProfileReference = new List<ReferenceType>();
            this.StudyUnit = new List<StudyUnitType>();
            this.SubGroup = new List<SubGroupType>();
            this.Reference = new List<ReferenceType>();

            this.Abstract.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "Abstract";
            };
            this.Purpose.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "Purpose";
            };
        }

        [System.Xml.Serialization.XmlAttribute()]
        public TimeGroupCodeType time { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public InstrumentGroupCodeType instrument { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public PanelGroupCodeType panel { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public GeographyGroupCodeType geography { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public DataSetGroupCodeType dataSet { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public LanguageGroupCodeType language { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string userDefinedGroupProperty { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string userDefinedGroupPropertyValue { get; set; }

        private Nullable<bool> _groupInherits;

        [System.Xml.Serialization.XmlAttribute()]
        public bool groupInherits
        {
            get
            {
                if (_groupInherits.HasValue)
                    return _groupInherits.Value;
                return true; //default value;
            }
            set
            {
                this._groupInherits = value;
            }
        }

        public bool ShouldSerializegroupInherits()
        {
            return _groupInherits.HasValue;
        }


        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public ObservableCollection<IdentifiedStructuredStringType> Abstract { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public ObservableCollection<IdentifiedStructuredStringType> Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 3)]
        public SeriesStatementType SeriesStatement { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<FundingInformationType> FundingInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 5)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 6)]
        public ReferenceType UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 7)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_1", Order = 8)]
        public ArchiveType Archive { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 9)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<ConceptType> Concepts { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<DataCollectionType> DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<LogicalProductType> LogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<PhysicalDataProductType> PhysicalDataProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:comparative:3_1", Order = 14)]
        public ComparisonType Comparison { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:ddiprofile:3_1", IsNullable = true, Order = 15)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ReferenceType> DDIProfileReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 17)]
        public List<StudyUnitType> StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 18)]
        public List<SubGroupType> SubGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 19)]
        public List<ReferenceType> Reference { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._groupInherits.HasValue) this._groupInherits = true;
            }
        }
    }
}