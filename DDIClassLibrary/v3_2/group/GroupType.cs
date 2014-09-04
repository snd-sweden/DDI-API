using DDIClassLibrary.v3_2.comparative;
using DDIClassLibrary.v3_2.archive;
using DDIClassLibrary.v3_2.ddiprofile;
using DDIClassLibrary.v3_2.reusable;
using DDIClassLibrary.v3_2.studyunit;
using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.conceptualcomponent;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.physicalinstance;
using DDIClassLibrary.v3_2.logicalproduct;
using DDIClassLibrary.v3_2.datacollection;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class GroupType : MaintainableType, IHaveDefaultValues
    {
        public GroupType()
        {
            this.AuthorizationSource = new List<AuthorizationSourceType>();
            this.SeriesStatement = new List<SeriesStatementType>();
            this.QualityStatementReference = new List<ReferenceType>();
            this.QualityStatementScheme = new List<QualityStatementSchemeType>();
            this.QualityStatementSchemeReference = new List<SchemeReferenceType>();
            this.ExPostEvaluation = new List<ExPostEvaluationType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.ProjectBudget = new List<BudgetType>();
            this.AnalysisUnit = new List<CodeValueType>();
            this.KindOfData = new List<KindOfDataType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Embargo = new List<EmbargoType>();
            this.ConceptualComponent = new List<ConceptualComponentType>();
            this.ConceptualComponentReference = new List<ReferenceType>();
            this.DataCollection = new List<DataCollectionType>();
            this.DataCollectionReference = new List<ReferenceType>();
            this.BaseLogicalProduct = new List<BaseLogicalProductType>();
            this.LogicalProductReference = new List<ReferenceType>();
            this.PhysicalDataProduct = new List<PhysicalDataProductType>();
            this.PhysicalDataProductReference = new List<ReferenceType>();
            this.PhysicalInstance = new List<PhysicalInstanceType>();
            this.PhysicalInstanceReference = new List<ReferenceType>();
            this.Archive = new List<ArchiveType>();
            this.ArchiveReference = new List<ReferenceType>();
            this.DDIProfile = new List<DDIProfileType>();
            this.DDIProfileReference = new List<ReferenceType>();
            this.Comparison = new List<ComparisonType>();
            this.ComparisonReference = new List<ReferenceType>();
            this.StudyUnit = new List<StudyUnitType>();
            this.StudyUnitReference = new List<ReferenceType>();
            this.SubGroup = new List<SubGroupType>();
            this.SubGroupReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 39)]
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


        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 40)]
        public Nullable<InstrumentGroupCodeType> captureInstrument { get; set; }

        public bool ShouldSerializecaptureInstrument()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "captureInstrument")]
        public string captureInstrumentValue
        {
            get
            {
                if (captureInstrument.HasValue)
                    return captureInstrument.ToString();
                return null;
            }
            set
            {
                InstrumentGroupCodeType result;
                Enum.TryParse<InstrumentGroupCodeType>(value, out result);
                captureInstrument = result;
            }
        }

        public bool ShouldSerializecaptureInstrumentValue()
        {
            return this.captureInstrument.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 41)]
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
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 42)]
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

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 43)]
        public Nullable<DataProductGroupCodeType> dataProduct { get; set; }

        public bool ShouldSerializedataProduct()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "dataProduct")]
        public string dataProductValue
        {
            get
            {
                if (dataProduct.HasValue)
                    return dataProduct.ToString();
                return null;
            }
            set
            {
                DataProductGroupCodeType result;
                Enum.TryParse<DataProductGroupCodeType>(value, out result);
                dataProduct = result;
            }
        }

        public bool ShouldSerializedataProductValue()
        {
            return this.dataProduct.HasValue;
        }
        
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 44)]
        public Nullable<LanguageGroupCodeType> languageRelationship { get; set; }

        public bool ShouldSerializelanguageRelationship()
        {
            return false;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "languageRelationship")]
        public string languageRelationshipValue
        {
            get
            {
                if (languageRelationship.HasValue)
                    return languageRelationship.ToString();
                return null;
            }
            set
            {
                LanguageGroupCodeType result;
                Enum.TryParse<LanguageGroupCodeType>(value, out result);
                languageRelationship = result;
            }
        }

        public bool ShouldSerializelanguageRelationshipValue()
        {
            return this.languageRelationship.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string userDefinedGroupProperty { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string userDefinedGroupPropertyValue { get; set; }

        private Nullable<bool> _isInheritable;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isInheritable
        {
            get
            {
                if (_isInheritable.HasValue)
                    return _isInheritable.Value;
                return true; //default value;
            }
            set
            {
                this._isInheritable = value;
            }
        }

        public bool ShouldSerializeisInheritable()
        {
            return _isInheritable.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Abstract { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<AuthorizationSourceType> AuthorizationSource { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public ReferenceType UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 4)]
        public List<SeriesStatementType> SeriesStatement { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<ReferenceType> QualityStatementReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<QualityStatementSchemeType> QualityStatementScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<SchemeReferenceType> QualityStatementSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 8)]
        public List<ExPostEvaluationType> ExPostEvaluation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 9)]
        public List<FundingInformationType> FundingInformation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<BudgetType> ProjectBudget { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 11)]
        public StructuredStringType Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 12)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 13)]
        public List<CodeValueType> AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 14)]
        public InternationalStringType AnalysisUnitCovered { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 15)]
        public List<KindOfDataType> KindOfData { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 16)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 17)]
        public RequiredResourcePackagesType RequiredResourcePackages { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 18)]
        public List<EmbargoType> Embargo { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 19)]
        public List<ConceptualComponentType> ConceptualComponent { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 20)]
        public List<ReferenceType> ConceptualComponentReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 21)]
        public List<DataCollectionType> DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 22)]
        public List<ReferenceType> DataCollectionReference { get; set; }

        [System.Xml.Serialization.XmlElement("LogicalProduct", typeof(DDIClassLibrary.v3_2.logicalproduct.LogicalProductType), Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 23)]
        public List<BaseLogicalProductType> BaseLogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 24)]
        public List<ReferenceType> LogicalProductReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", IsNullable = true, Order = 25)]
        public List<PhysicalDataProductType> PhysicalDataProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 26)]
        public List<ReferenceType> PhysicalDataProductReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicalinstance:3_2", IsNullable = true, Order = 27)]
        public List<PhysicalInstanceType> PhysicalInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 28)]
        public List<ReferenceType> PhysicalInstanceReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_2", IsNullable = true, Order = 29)]
        public List<ArchiveType> Archive { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 30)]
        public List<ReferenceType> ArchiveReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:ddiprofile:3_2", IsNullable = true, Order = 31)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 32)]
        public List<ReferenceType> DDIProfileReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:comparison:3_2", IsNullable = true, Order = 33)]
        public List<ComparisonType> Comparison { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 34)]
        public List<ReferenceType> ComparisonReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:studyunit:3_2", IsNullable = true, Order = 35)]
        public List<StudyUnitType> StudyUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 36)]
        public List<ReferenceType> StudyUnitReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 37)]
        public List<SubGroupType> SubGroup { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 38)]
        public List<ReferenceType> SubGroupReference { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (!this._isInheritable.HasValue) this._isInheritable = true;
                if (!this.time.HasValue) this.time = TimeGroupCodeType.T0;
                if (!this.captureInstrument.HasValue) this.captureInstrument = InstrumentGroupCodeType.I0;
                if (!this.panel.HasValue) this.panel = PanelGroupCodeType.P0;
                if (!this.geography.HasValue) this.geography = GeographyGroupCodeType.G0;
                if (!this.dataProduct.HasValue) this.dataProduct = DataProductGroupCodeType.D0;
                if (!this.languageRelationship.HasValue) this.languageRelationship = LanguageGroupCodeType.L0;
            }
        }
    }
}