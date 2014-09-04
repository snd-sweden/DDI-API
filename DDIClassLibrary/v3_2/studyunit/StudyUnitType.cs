using DDIClassLibrary.v3_2.archive;
using DDIClassLibrary.v3_2.conceptualcomponent;
using DDIClassLibrary.v3_2.datacollection;
using DDIClassLibrary.v3_2.ddiprofile;
using DDIClassLibrary.v3_2.logicalproduct;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.physicalinstance;
using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.studyunit
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:studyunit:3_2")]
    public class StudyUnitType : MaintainableType
    {
        public StudyUnitType()
        {
            this.AuthorizationSource = new List<AuthorizationSourceType>();
            this.SeriesStatement = new List<SeriesStatementType>();
            this.QualityStatementReference = new List<ReferenceType>();
            this.QualityStatementScheme = new List<QualityStatementSchemeType>();
            this.QualityStatementSchemeReference = new List<SchemeReferenceType>();
            this.ExPostEvaluation = new List<ExPostEvaluationType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.StudyBudget = new List<BudgetType>();
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
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Abstract { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<AuthorizationSourceType> AuthorizationSource { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 3)]
        public ReferenceType UniverseReference { get; set; }

        public bool ShouldSerializeUniverseReference()
        {
            return UniverseReference != null;
        }

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
        public List<BudgetType> StudyBudget { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 11)]
        public StructuredStringType Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 12)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 13)]
        public List<CodeValueType> AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 14)]
        public InternationalStringType AnalysisUnitsCovered { get; set; }

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
        
    }
}