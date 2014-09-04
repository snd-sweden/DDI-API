using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class ProcessingType : IdentifiableType
    {
        public ProcessingType()
        {
            this.ObjectType = "Processing";

            this.ControlOperation = new List<OperationType>();
            this.CleaningOperation = new List<OperationType>();
            this.Weighting = new ObservableCollection<IdentifiedStructuredStringType>();
            this.DataAppraisalInformation = new List<DataAppraisalInformationType>();
            this.Coding = new List<CodingType>();

            this.Weighting.CollectionChanged += (sender, args) =>
            {
                foreach (IdentifiedStructuredStringType x in args.NewItems)
                    x.ObjectType = "Weighting";
            };
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<OperationType> ControlOperation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<OperationType> CleaningOperation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public ObservableCollection<IdentifiedStructuredStringType> Weighting { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<DataAppraisalInformationType> DataAppraisalInformation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<CodingType> Coding { get; set; }
    }
}