using DDIClassLibrary.v3_2.archive;
using DDIClassLibrary.v3_2.comparative;
using DDIClassLibrary.v3_2.conceptualcomponent;
using DDIClassLibrary.v3_2.datacollection;
using DDIClassLibrary.v3_2.ddiprofile;
using DDIClassLibrary.v3_2.logicalproduct;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.physicalinstance;
using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public class ResourcePackageType : MaintainableType
    {
        public ResourcePackageType()
        {
            this.Abstract = new List<StructuredStringType>();
            this.AuthorizationSource = new List<AuthorizationSourceType>();
            this.SeriesStatement = new List<SeriesStatementType>();
            this.QualityStatementReference = new List<ReferenceType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.ProjectBudget = new List<BudgetType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Embargo = new List<EmbargoType>();
            this.ResourcePackageArchive = new List<ResourcePackageArchiveType>();
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
            this.OrganizationScheme = new List<OrganizationSchemeType>();
            this.OrganizationSchemeReference = new List<SchemeReferenceType>();
            this.ConceptScheme = new List<ConceptSchemeType>();
            this.ConceptSchemeReference = new List<SchemeReferenceType>();
            this.UniverseScheme = new List<UniverseSchemeType>();
            this.UniverseSchemeReference = new List<SchemeReferenceType>();
            this.ConceptualVariableScheme = new List<ConceptualVariableSchemeType>();
            this.ConceptualVariableSchemeReference = new List<SchemeReferenceType>();
            this.RepresentedVariableScheme = new List<RepresentedVariableSchemeType>();
            this.RepresentedVariableSchemeReference = new List<SchemeReferenceType>();
            this.GeographicStructureScheme = new List<GeographicStructureSchemeType>();
            this.GeographicStructureSchemeReference = new List<SchemeReferenceType>();
            this.ControlConstructScheme = new List<ControlConstructSchemeType>();
            this.ControlConstructSchemeReference = new List<SchemeReferenceType>();
            this.QuestionScheme = new List<QuestionSchemeType>();
            this.QuestionSchemeReference = new List<SchemeReferenceType>();
            this.CategoryScheme = new List<CategorySchemeType>();
            this.CategorySchemeReference = new List<SchemeReferenceType>();
            this.CodeListScheme = new List<CodeListSchemeType>();
            this.CodeListSchemeReference = new List<SchemeReferenceType>();
            this.NCubeScheme = new List<NCubeSchemeType>();
            this.NCubeSchemeReference = new List<SchemeReferenceType>();
            this.VariableScheme = new List<VariableSchemeType>();
            this.VariableSchemeReference = new List<SchemeReferenceType>();
            this.PhysicalStructureScheme = new List<PhysicalStructureSchemeType>();
            this.PhysicalStructureSchemeReference = new List<SchemeReferenceType>();
            this.RecordLayoutScheme = new List<RecordLayoutSchemeType>();
            this.RecordLayoutSchemeReference = new List<SchemeReferenceType>();
            this.QualityStatementScheme = new List<QualityStatementSchemeType>();
            this.QualityStatementSchemeReference = new List<SchemeReferenceType>();
            this.InstrumentScheme = new List<InstrumentSchemeType>();
            this.InstrumentSchemeReference = new List<SchemeReferenceType>();
            this.ProcessingEventScheme = new List<ProcessingEventSchemeType>();
            this.ProcessingEventSchemeReference = new List<SchemeReferenceType>();
            this.ProcessingInstructionScheme = new List<ProcessingInstructionSchemeType>();
            this.ProcessingInstructionSchemeReference = new List<SchemeReferenceType>();
            this.ManagedRepresentationScheme = new List<ManagedRepresentationSchemeType>();
            this.ManagedRepresentationSchemeReference = new List<SchemeReferenceType>();                

        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CodeValueType TypeOfResourcePackage { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> Abstract { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<AuthorizationSourceType> AuthorizationSource { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 4)]
        public ReferenceType UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 5)]
        public List<SeriesStatementType> SeriesStatement { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 6)]
        public List<ReferenceType> QualityStatementReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 7)]
        public List<FundingInformationType> FundingInformation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<BudgetType> ProjectBudget { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 9)]
        public List<StructuredStringType> Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 10)]
        public CoverageType Coverage { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 11)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 12)]
        public List<EmbargoType> Embargo { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 13)]
        public List<ResourcePackageArchiveType> ResourcePackageArchive { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 14)]
        public List<ConceptualComponentType> ConceptualComponent { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 15)]
        public List<ReferenceType> ConceptualComponentReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 16)]
        public List<DataCollectionType> DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 17)]
        public List<ReferenceType> DataCollectionReference { get; set; }

        [System.Xml.Serialization.XmlElement("LogicalProduct", typeof(DDIClassLibrary.v3_2.logicalproduct.LogicalProductType), Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 18)]
        public List<BaseLogicalProductType> BaseLogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 19)]
        public List<ReferenceType> LogicalProductReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", IsNullable = true, Order = 20)]
        public List<PhysicalDataProductType> PhysicalDataProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 21)]
        public List<ReferenceType> PhysicalDataProductReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicalinstance:3_2", IsNullable = true, Order = 22)]
        public List<PhysicalInstanceType> PhysicalInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 23)]
        public List<ReferenceType> PhysicalInstanceReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_2", IsNullable = true, Order = 24)]
        public List<ArchiveType> Archive { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 25)]
        public List<ReferenceType> ArchiveReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:ddiprofile:3_2", IsNullable = true, Order = 26)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 27)]
        public List<ReferenceType> DDIProfileReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:comparison:3_2", IsNullable = true, Order = 28)]
        public List<ComparisonType> Comparison { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 29)]
        public List<ReferenceType> ComparisonReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_2", IsNullable = true, Order = 30)]
        public List<OrganizationSchemeType> OrganizationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 31)]
        public List<SchemeReferenceType> OrganizationSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 32)]
        public List<ConceptSchemeType> ConceptScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 33)]
        public List<SchemeReferenceType> ConceptSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 34)]
        public List<UniverseSchemeType> UniverseScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 35)]
        public List<SchemeReferenceType> UniverseSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 36)]
        public List<ConceptualVariableSchemeType> ConceptualVariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 37)]
        public List<SchemeReferenceType> ConceptualVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 38)]
        public List<RepresentedVariableSchemeType> RepresentedVariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 39)]
        public List<SchemeReferenceType> RepresentedVariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 40)]
        public List<GeographicStructureSchemeType> GeographicStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 41)]
        public List<SchemeReferenceType> GeographicStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_2", IsNullable = true, Order = 42)]
        public List<GeographicLocationSchemeType> GeographicLocationScheme { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 43)]
        public List<SchemeReferenceType> GeographicLocationSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 44)]
        public List<InterviewerInstructionSchemeType> InterviewerInstructionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 45)]
        public List<SchemeReferenceType> InterviewerInstructionSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 46)]
        public List<ControlConstructSchemeType> ControlConstructScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 47)]
        public List<SchemeReferenceType> ControlConstructSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 48)]
        public List<QuestionSchemeType> QuestionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 49)]
        public List<SchemeReferenceType> QuestionSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 50)]
        public List<CategorySchemeType> CategoryScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 51)]
        public List<SchemeReferenceType> CategorySchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 52)]
        public List<CodeListSchemeType> CodeListScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 53)]
        public List<SchemeReferenceType> CodeListSchemeReference { get; set; }
        
        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 54)]
        public List<NCubeSchemeType> NCubeScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 55)]
        public List<SchemeReferenceType> NCubeSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_2", IsNullable = true, Order = 56)]
        public List<VariableSchemeType> VariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 57)]
        public List<SchemeReferenceType> VariableSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", IsNullable = true, Order = 58)]
        public List<PhysicalStructureSchemeType> PhysicalStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 59)]
        public List<SchemeReferenceType> PhysicalStructureSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_2", IsNullable = true, Order = 60)]
        public List<RecordLayoutSchemeType> RecordLayoutScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 61)]
        public List<SchemeReferenceType> RecordLayoutSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 62)]
        public List<QualityStatementSchemeType> QualityStatementScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 63)]
        public List<SchemeReferenceType> QualityStatementSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 64)]
        public List<InstrumentSchemeType> InstrumentScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 65)]
        public List<SchemeReferenceType> InstrumentSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 66)]
        public List<ProcessingEventSchemeType> ProcessingEventScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 67)]
        public List<SchemeReferenceType> ProcessingEventSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_2", IsNullable = true, Order = 68)]
        public List<ProcessingInstructionSchemeType> ProcessingInstructionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 69)]
        public List<SchemeReferenceType> ProcessingInstructionSchemeReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 70)]
        public List<ManagedRepresentationSchemeType> ManagedRepresentationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 71)]
        public List<SchemeReferenceType> ManagedRepresentationSchemeReference { get; set; }

    }
}