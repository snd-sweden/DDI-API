using System;
using System.Collections.Generic;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class SeriesStatementType
    {
        public SeriesStatementType()
        {
            this.SeriesName = new List<NameType>();
            this.Abbreviation = new List<string>();
            this.SeriesDescription = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlElement(DataType = "anyURI", Order = 0)]
        public String SeriesRepositoryLocation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<NameType> SeriesName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<String> Abbreviation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<StructuredStringType> SeriesDescription { get; set; }
    }
}