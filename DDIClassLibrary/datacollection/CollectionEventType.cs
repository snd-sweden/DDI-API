using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class CollectionEventType : IdentifiableType
    {
        public CollectionEventType()
        {
            this.ObjectType = "CollectionEvent";

            this.DataCollectorOrganizationReference = new List<ReferenceType>();
            this.DataSource = new List<DataSourceType>();
            this.DataCollectionFrequency = new List<DataCollectionFrequencyType>();
            this.ModeOfCollection = new ObservableCollection<IdentifiedStructuredStringType>();
            this.CollectionSituation = new ObservableCollection<IdentifiedStructuredStringType>();
            this.ActionToMinimizeLosses = new ObservableCollection<IdentifiedStructuredStringType>();

            this.ModeOfCollection.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "ModeOfCollection";
            };
            this.CollectionSituation.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "CollectionSituation";
            };
            this.ActionToMinimizeLosses.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "ActionToMinimizeLosses";
            };
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
        public ObservableCollection<IdentifiedStructuredStringType> ModeOfCollection { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public ObservableCollection<IdentifiedStructuredStringType> CollectionSituation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 6)]
        public ObservableCollection<IdentifiedStructuredStringType> ActionToMinimizeLosses { get; set; }
    }
}