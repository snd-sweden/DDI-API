using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class SeriesStatementType
    {
        public SeriesStatementType()
        {
            this.SeriesRepositoryLocation = new List<string>();
            this.SeriesName = new List<NameType>();
            this.SeriesAbbreviation = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 0)]
        public List<string> SeriesRepositoryLocation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = false, Order = 1)]
        public List<NameType> SeriesName { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<CodeValueType> SeriesAbbreviation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public StructuredStringType SeriesDescription { get; set; }
    }
}