using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DDIClassLibrary.archive;
using DDIClassLibrary.comparative;
using DDIClassLibrary.conceptualcomponent;
using DDIClassLibrary.datacollection;
using DDIClassLibrary.ddiprofile;
using DDIClassLibrary.logicalproduct;
using DDIClassLibrary.physicaldataproduct;
using DDIClassLibrary.physicalinstance;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_1")]
    public class ResourcePackageType : MaintainableType
    {
        public ResourcePackageType()
        {
            this.ObjectType = "ResourcePackage";

            this.Abstract = new ObservableCollection<IdentifiedStructuredStringType>();
            this.Purpose = new ObservableCollection<IdentifiedStructuredStringType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
            this.Concepts = new List<ConceptType>();
            this.DataCollection = new List<DataCollectionType>();
            this.LogicalProduct = new List<LogicalProductType>();
            this.PhysicalDataProduct = new List<PhysicalDataProductType>();
            this.PhysicalInstance = new List<PhysicalInstanceType>();
            this.DDIProfile = new List<DDIProfileType>();
            this.DDIProfileReference = new List<ReferenceType>();
            this.OrganizationScheme = new List<OrganizationSchemeType>();
            this.ConceptScheme = new List<ConceptSchemeType>();
            this.UniverseScheme = new List<UniverseSchemeType>();
            this.GeographicStructureScheme = new List<GeographicStructureSchemeType>();
            this.GeographicLocationScheme = new List<GeographicLocationSchemeType>();
            this.InterviewerInstructionScheme = new List<InterviewerInstructionSchemeType>();
            this.ControlConstructScheme = new List<ControlConstructSchemeType>();
            this.QuestionScheme = new List<QuestionSchemeType>();
            this.CategoryScheme = new List<CategorySchemeType>();
            this.CodeScheme = new List<CodeSchemeType>();
            this.NCubeScheme = new List<NCubeSchemeType>();
            this.VariableScheme = new List<VariableSchemeType>();
            this.PhysicalStructureScheme = new List<PhysicalStructureSchemeType>();
            this.RecordLayoutScheme = new List<RecordLayoutSchemeType>();

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

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public ObservableCollection<IdentifiedStructuredStringType> Abstract { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 2)]
        public ObservableCollection<IdentifiedStructuredStringType> Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 3)]
        public List<FundingInformationType> FundingInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 4)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 5)]
        public ReferenceType UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 6)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_1", Order = 7)]
        public ArchiveType Archive { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 8)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<ConceptType> Concepts { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 10)]
        public List<DataCollectionType> DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 11)]
        public List<LogicalProductType> LogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 12)]
        public List<PhysicalDataProductType> PhysicalDataProduct { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicalinstance:3_1", IsNullable = true, Order = 13)]
        public List<PhysicalInstanceType> PhysicalInstance { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:comparative:3_1", Order = 14)]
        public ComparisonType Comparison { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:ddiprofile:3_1", IsNullable = true, Order = 15)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ReferenceType> DDIProfileReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_1", IsNullable = true, Order = 17)]
        public List<OrganizationSchemeType> OrganizationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_1", IsNullable = true, Order = 18)]
        public List<ConceptSchemeType> ConceptScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_1", IsNullable = true, Order = 19)]
        public List<UniverseSchemeType> UniverseScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_1", IsNullable = true, Order = 20)]
        public List<GeographicStructureSchemeType> GeographicStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_1", IsNullable = true, Order = 21)]
        public List<GeographicLocationSchemeType> GeographicLocationScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", IsNullable = true, Order = 22)]
        public List<InterviewerInstructionSchemeType> InterviewerInstructionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", IsNullable = true, Order = 23)]
        public List<ControlConstructSchemeType> ControlConstructScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", IsNullable = true, Order = 24)]
        public List<QuestionSchemeType> QuestionScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_1", IsNullable = true, Order = 25)]
        public List<CategorySchemeType> CategoryScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_1", IsNullable = true, Order = 26)]
        public List<CodeSchemeType> CodeScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_1", IsNullable = true, Order = 27)]
        public List<NCubeSchemeType> NCubeScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_1", IsNullable = true, Order = 28)]
        public List<VariableSchemeType> VariableScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_1", IsNullable = true, Order = 29)]
        public List<PhysicalStructureSchemeType> PhysicalStructureScheme { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_1", IsNullable = true, Order = 30)]
        public List<RecordLayoutSchemeType> RecordLayoutScheme { get; set; }
    }
}