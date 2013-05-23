using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DDIClassLibrary.archive;
using DDIClassLibrary.conceptualcomponent;
using DDIClassLibrary.datacollection;
using DDIClassLibrary.ddiprofile;
using DDIClassLibrary.logicalproduct;
using DDIClassLibrary.physicaldataproduct;
using DDIClassLibrary.physicalinstance;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.studyunit
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:studyunit:3_1")]
    public class StudyUnitType : MaintainableType
    {
        public StudyUnitType()
        {
            this.ObjectType = "StudyUnit";

            this.Abstract = new ObservableCollection<IdentifiedStructuredStringType>();
            this.UniverseReference = new List<ReferenceType>();
            this.FundingInformation = new List<FundingInformationType>();
            this.Purpose = new ObservableCollection<IdentifiedStructuredStringType>();
            this.AnalysisUnit = new List<CodeValueType>();
            this.AnalysisUnitsCovered = new List<InternationalStringType>();
            this.KindOfData = new List<KindOfDataType>();
            this.OtherMaterial = new List<OtherMaterialType>();
            this.Note = new List<NoteType>();
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
            this.ArchiveReference = new List<ReferenceType>();
            this.DDIProfile = new List<DDIProfileType>();
            this.DDIProfileReference = new List<ReferenceType>();

            this.Abstract.CollectionChanged += (sender, args) =>
            {
                foreach(IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "Abstract";
            };
            this.Purpose.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "Abstract";
            };
        }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 0)]
        public CitationType Citation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public ObservableCollection<IdentifiedStructuredStringType> Abstract { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = false, Order = 2)]
        public List<ReferenceType> UniverseReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 3)]
        public SeriesStatementType SeriesStatement { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<FundingInformationType> FundingInformation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 5)]
        public ObservableCollection<IdentifiedStructuredStringType> Purpose { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", Order = 6)]
        public CoverageType Coverage { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 7)]
        public List<CodeValueType> AnalysisUnit { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<InternationalStringType> AnalysisUnitsCovered { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 9)]
        public List<KindOfDataType> KindOfData { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 10)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 11)]
        public List<NoteType> Note { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 12)]
        public List<EmbargoType> Embargo { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:conceptualcomponent:3_1", IsNullable = true, Order = 13)]
        public List<ConceptualComponentType> ConceptualComponent { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 14)]
        public List<ReferenceType> ConceptualComponentReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:datacollection:3_1", IsNullable = true, Order = 15)]
        public List<DataCollectionType> DataCollection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 16)]
        public List<ReferenceType> DataCollectionReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:logicalproduct:3_1", IsNullable = true, Order = 17)]
        public List<BaseLogicalProductType> BaseLogicalProduct { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 18)]
        public List<ReferenceType> LogicalProductReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:physicaldataproduct:3_1", IsNullable = true, Order = 19)]
        public List<PhysicalDataProductType> PhysicalDataProduct { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 20)]
        public List<ReferenceType> PhysicalDataProductReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 21)]
        public List<PhysicalInstanceType> PhysicalInstance { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 22)]
        public List<ReferenceType> PhysicalInstanceReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:archive:3_1", Order = 23)]
        public ArchiveType Archive { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 24)]
        public List<ReferenceType> ArchiveReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:ddiprofile:3_1", IsNullable = true, Order = 25)]
        public List<DDIProfileType> DDIProfile { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 26)]
        public List<ReferenceType> DDIProfileReference { get; set; }

        internal override void CreateURN(string agencyID)
        {
 	        base.CreateURN(agencyID);

        }
    }
}