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
    public class GroupType : MaintainableType, IHaveDefaultValues
    {
        public GroupType()
        {
            this.ObjectType = "Group";

            this.Abstract = new ObservableCollection<IdentifiedStructuredStringType>();
            this.Purpose = new ObservableCollection<IdentifiedStructuredStringType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.Concepts = new List<ConceptType>();
            this.DataCollection = new List<DataCollectionType>();
            this.LogicalProduct = new List<LogicalProductType>();
            this.PhysicalDataProduct = new List<PhysicalDataProductType>();
            this.StudyUnit = new List<StudyUnitType>();
            this.SubGroup = new List<SubGroupType>();
            this.DDIProfile = new List<DDIProfileType>();
            this.DDIProfileReference = new List<ReferenceType>();
                        
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

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 19)]
        public Nullable<TimeGroupCodeType> time { get; set; }

        public bool ShouldSerializetime()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "time")]
        public string timeValue
        {
            get
            {
                if (time.HasValue)
                    return time.ToString();
                return null;
            }
            set
            {
                TimeGroupCodeType result;
                Enum.TryParse<TimeGroupCodeType>(value, out result);
                time = result;
            }
        }

        public bool ShouldSerializetimeValue()
        {
            return this.time.HasValue;
        }


        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 20)]
        public Nullable<InstrumentGroupCodeType> instrument { get; set; }

        public bool ShouldSerializeinstrument()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "instrument")]
        public string instrumentValue
        {
            get
            {
                if (instrument.HasValue)
                    return instrument.ToString();
                return null;
            }
            set
            {
                InstrumentGroupCodeType result;
                Enum.TryParse<InstrumentGroupCodeType>(value, out result);
                instrument = result;
            }
        }

        public bool ShouldSerializeinstrumentValue()
        {
            return this.instrument.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 21)]
        public Nullable<PanelGroupCodeType> panel { get; set; }

        public bool ShouldSerializepanel()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "panel")]
        public string panelValue
        {
            get
            {
                if (panel.HasValue)
                    return panel.ToString();
                return null;
            }
            set
            {
                PanelGroupCodeType result;
                Enum.TryParse<PanelGroupCodeType>(value, out result);
                panel = result;
            }
        }

        public bool ShouldSerializepanelValue()
        {
            return this.panel.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 22)]
        public Nullable<GeographyGroupCodeType> geography { get; set; }

        public bool ShouldSerializegeography()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "geography")]
        public string geographyValue
        {
            get
            {
                if (geography.HasValue)
                    return geography.ToString();
                return null;
            }
            set
            {
                GeographyGroupCodeType result;
                Enum.TryParse<GeographyGroupCodeType>(value, out result);
                geography = result;
            }
        }

        public bool ShouldSerializegeographyValue()
        {
            return this.geography.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 23)]
        public Nullable<DataSetGroupCodeType> dataSet { get; set; }

        public bool ShouldSerializedataSet()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "dataSet")]
        public string dataSetValue
        {
            get
            {
                if (dataSet.HasValue)
                    return dataSet.ToString();
                return null;
            }
            set
            {
                DataSetGroupCodeType result;
                Enum.TryParse<DataSetGroupCodeType>(value, out result);
                dataSet = result;
            }
        }

        public bool ShouldSerializedataSetValue()
        {
            return this.dataSet.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 24)]
        public Nullable<LanguageGroupCodeType> language { get; set; }

        public bool ShouldSerializelanguage()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "language")]
        public string languageValue
        {
            get
            {
                if (language.HasValue)
                    return language.ToString();
                return null;
            }
            set
            {
                LanguageGroupCodeType result;
                Enum.TryParse<LanguageGroupCodeType>(value, out result);
                language = result;
            }
        }

        public bool ShouldSerializelanguageValue()
        {
            return this.language.HasValue;
        }

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

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<StudyUnitType> StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 15)]
        public List<SubGroupType> SubGroup { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:comparative:3_1", Order = 16)]
        public ComparisonType Comparison { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:ddiprofile:3_1", IsNullable = true, Order = 17)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 18)]
        public List<ReferenceType> DDIProfileReference { get; set; }

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
                if (!this.time.HasValue) this.time = TimeGroupCodeType.T0;
                if (!this.instrument.HasValue) this.instrument = InstrumentGroupCodeType.I0;
                if (!this.panel.HasValue) this.panel = PanelGroupCodeType.P0;
                if (!this.geography.HasValue) this.geography = GeographyGroupCodeType.G0;
                if (!this.dataSet.HasValue) this.dataSet = DataSetGroupCodeType.D0;
                if (!this.language.HasValue) this.language = LanguageGroupCodeType.L0;
            }
        }
    }
}