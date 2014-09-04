using System.Collections.Generic;
using System.Collections.ObjectModel;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class MethodologyType : VersionableType
    {
        public MethodologyType()
        {
            this.ObjectType = "Methodology";

            this.DataCollectionMethodology = new ObservableCollection<IdentifiedStructuredStringType>();
            this.TimeMethod = new ObservableCollection<IdentifiedStructuredStringType>();
            this.SamplingProcedure = new ObservableCollection<IdentifiedStructuredStringType>();
            this.DeviationFromSampleDesign = new ObservableCollection<IdentifiedStructuredStringType>();
            this.Software = new List<SoftwareType>();

            this.DataCollectionMethodology.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "DataCollectionMethodology";
            };
            this.TimeMethod.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "TimeMethod";
            };
            this.SamplingProcedure.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "SamplingProcedure";
            };
            this.DeviationFromSampleDesign.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "DeviationFromSampleDesign";
            };
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ObservableCollection<IdentifiedStructuredStringType> DataCollectionMethodology { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public ObservableCollection<IdentifiedStructuredStringType> TimeMethod { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public ObservableCollection<IdentifiedStructuredStringType> SamplingProcedure { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public ObservableCollection<IdentifiedStructuredStringType> DeviationFromSampleDesign { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<SoftwareType> Software { get; set; }
    }
}