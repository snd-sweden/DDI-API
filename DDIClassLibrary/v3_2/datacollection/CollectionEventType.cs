using DDIClassLibrary.v3_2.reusable;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class CollectionEventType : IdentifiableType
    {
        public CollectionEventType()
        {
            this.DataCollectorOrganizationReference = new List<ReferenceType>();
            this.DataSource = new List<DataSourceType>();
            this.DataCollectionFrequency = new List<DataCollectionFrequencyType>();
            this.ModeOfCollection = new List<ModeOfCollectionType>();
            this.InstrumentReference = new List<ReferenceType>();
            this.CollectionSituation = new List<CollectionSituationType>();
            this.ActionToMinimizeLosses = new List<ActionToMinimizeLossesType>();
            this.QualityStatementReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> DataCollectorOrganizationReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<DataSourceType> DataSource { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public DateType DataCollectionDate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DataCollectionFrequencyType> DataCollectionFrequency { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ModeOfCollectionType> ModeOfCollection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> InstrumentReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public List<CollectionSituationType> CollectionSituation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 7)]
        public List<ActionToMinimizeLossesType> ActionToMinimizeLosses { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 8)]
        public List<ReferenceType> QualityStatementReference { get; set; }

    }
}