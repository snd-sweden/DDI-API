using System.Collections.Generic;
using DDIClassLibrary.v3_2.dc_elements;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class CitationType
    {
        public CitationType()
        {            
            this.SubTitle = new List<InternationalStringType>();
            this.AlternateTitle = new List<InternationalStringType>();
            this.Creator = new List<CreatorType>();
            this.Publisher = new List<PublisherType>();
            this.Contributor = new List<ContributorType>();
            this.Language = new List<CodeValueType>();
            this.InternationalIdentifier = new List<InternationalIdentifierType>();

            this.DCAbstract = new List<SimpleLiteral>();
            this.DCAccessRights = new List<SimpleLiteral>();
            this.DCAlternative = new List<SimpleLiteral>();
            this.DCAudience = new List<SimpleLiteral>();
            this.DCAvailable = new List<SimpleLiteral>();
            this.DCBibliographicCitation = new List<SimpleLiteral>();
            this.DCConformsTo = new List<SimpleLiteral>();
            this.DCContributor = new List<SimpleLiteral>();
            this.DCCoverage = new List<SimpleLiteral>();
            this.DCCreated = new List<SimpleLiteral>();
            this.DCCreator = new List<SimpleLiteral>();
            this.DCDate = new List<SimpleLiteral>();
            this.DCDateAccepted = new List<SimpleLiteral>();
            this.DCDateCopyrighted = new List<SimpleLiteral>();
            this.DCDescription = new List<SimpleLiteral>();
            this.DCEducationLevel = new List<SimpleLiteral>();
            this.DCExtent = new List<SimpleLiteral>();
            this.DCFormat = new List<SimpleLiteral>();
            this.DCHasFormat = new List<SimpleLiteral>();
            this.DCHasPart = new List<SimpleLiteral>();
            this.DCHasVersion = new List<SimpleLiteral>();
            this.DCIdentifier = new List<SimpleLiteral>();
            this.DCIsFormatOf = new List<SimpleLiteral>();
            this.DCIsPartOf = new List<SimpleLiteral>();
            this.DCIsReferencedBy = new List<SimpleLiteral>();
            this.DCIsReplacedBy = new List<SimpleLiteral>();
            this.DCIsRequiredBy = new List<SimpleLiteral>();
            this.DCIssued = new List<SimpleLiteral>();
            this.DCIsVersionOf = new List<SimpleLiteral>();
            this.DCLanguage = new List<SimpleLiteral>();
            this.DCMediator = new List<SimpleLiteral>();
            this.DCMedium = new List<SimpleLiteral>();
            this.DCModified = new List<SimpleLiteral>();
            this.DCPublisher = new List<SimpleLiteral>();
            this.DCReferences = new List<SimpleLiteral>();
            this.DCRelation = new List<SimpleLiteral>();
            this.DCReplaces = new List<SimpleLiteral>();
            this.DCRequires = new List<SimpleLiteral>();
            this.DCRights = new List<SimpleLiteral>();
            this.DCSource = new List<SimpleLiteral>();
            this.DCSpatial = new List<SimpleLiteral>();
            this.DCSubject = new List<SimpleLiteral>();
            this.DCSubmitted = new List<SimpleLiteral>();
            this.DCTableOfContents = new List<SimpleLiteral>();
            this.DCTemporal = new List<SimpleLiteral>();
            this.DCTitle = new List<SimpleLiteral>();
            this.DCType = new List<SimpleLiteral>();
            this.DCValid = new List<SimpleLiteral>();

        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public InternationalStringType Title { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<InternationalStringType> SubTitle { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<InternationalStringType> AlternateTitle { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<CreatorType> Creator { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<PublisherType> Publisher { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ContributorType> Contributor { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public DateType PublicationDate { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public List<CodeValueType> Language { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 8)]
        public List<InternationalIdentifierType> InternationalIdentifier { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public InternationalStringType Copyright { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "abstract", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 10)]
        public List<SimpleLiteral> DCAbstract { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "accessRights", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 11)]
        public List<SimpleLiteral> DCAccessRights { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "alternative", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 12)]
        public List<SimpleLiteral> DCAlternative { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "audience", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 13)]
        public List<SimpleLiteral> DCAudience { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "available", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 14)]
        public List<SimpleLiteral> DCAvailable { get; set; }
                
        [System.Xml.Serialization.XmlElement(ElementName = "bibliographicCitation", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 15)]
        public List<SimpleLiteral> DCBibliographicCitation { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "conformsTo", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 16)]
        public List<SimpleLiteral> DCConformsTo { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "contributor", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 17)]
        public List<SimpleLiteral> DCContributor { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "coverage", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 18)]
        public List<SimpleLiteral> DCCoverage { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "created", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 19)]
        public List<SimpleLiteral> DCCreated { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "creator", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 20)]
        public List<SimpleLiteral> DCCreator { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "date", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 21)]
        public List<SimpleLiteral> DCDate { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "dateAccepted", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 22)]
        public List<SimpleLiteral> DCDateAccepted { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "dateCopyrighted", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 23)]
        public List<SimpleLiteral> DCDateCopyrighted { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "dateSubmitted", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 24)]
        public List<SimpleLiteral> DCSubmitted { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "description", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 25)]
        public List<SimpleLiteral> DCDescription { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "educationLevel", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 26)]
        public List<SimpleLiteral> DCEducationLevel { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "extent", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 27)]
        public List<SimpleLiteral> DCExtent { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "format", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 28)]
        public List<SimpleLiteral> DCFormat { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "hasFormat", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 29)]
        public List<SimpleLiteral> DCHasFormat { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "hasPart", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 30)]
        public List<SimpleLiteral> DCHasPart { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "hasVersion", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 31)]
        public List<SimpleLiteral> DCHasVersion { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "identifier", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 32)]
        public List<SimpleLiteral> DCIdentifier { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "isFormatOf", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 33)]
        public List<SimpleLiteral> DCIsFormatOf { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "isPartOf", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 34)]
        public List<SimpleLiteral> DCIsPartOf { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "isReferencedBy", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 35)]
        public List<SimpleLiteral> DCIsReferencedBy { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "isReplacedBy", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 36)]
        public List<SimpleLiteral> DCIsReplacedBy { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "isRequiredBy", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 37)]
        public List<SimpleLiteral> DCIsRequiredBy { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "isVersionOf", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 38)]
        public List<SimpleLiteral> DCIsVersionOf { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "issued", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 39)]
        public List<SimpleLiteral> DCIssued { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "language", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 40)]
        public List<SimpleLiteral> DCLanguage { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "mediator", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 41)]
        public List<SimpleLiteral> DCMediator { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "medium", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 42)]
        public List<SimpleLiteral> DCMedium { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "modified", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 43)]
        public List<SimpleLiteral> DCModified { get; set; }
        
        [System.Xml.Serialization.XmlElement(ElementName = "publisher", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 44)]
        public List<SimpleLiteral> DCPublisher { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "references", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 45)]
        public List<SimpleLiteral> DCReferences { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "relation", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 46)]
        public List<SimpleLiteral> DCRelation { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "replaces", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 47)]
        public List<SimpleLiteral> DCReplaces { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "requires", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 48)]
        public List<SimpleLiteral> DCRequires { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "rights", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 49)]
        public List<SimpleLiteral> DCRights { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "source", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 50)]
        public List<SimpleLiteral> DCSource { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "spatial", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 51)]
        public List<SimpleLiteral> DCSpatial { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "subject", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 52)]
        public List<SimpleLiteral> DCSubject { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "tableOfContents", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 53)]
        public List<SimpleLiteral> DCTableOfContents { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "temporal", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 54)]
        public List<SimpleLiteral> DCTemporal { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "title", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 55)]
        public List<SimpleLiteral> DCTitle { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true, Order = 56)]
        public List<SimpleLiteral> DCType { get; set; }

        [System.Xml.Serialization.XmlElement(ElementName = "valid", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://purl.org/dc/terms/", IsNullable = true, Order = 57)]
        public List<SimpleLiteral> DCValid { get; set; }
 
    }
}