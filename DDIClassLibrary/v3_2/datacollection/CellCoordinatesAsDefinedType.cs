using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class CellCoordinatesAsDefinedType
    {
        public CellCoordinatesAsDefinedType()
        {
            this.SelectDimension = new List<SelectDimensionType>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<SelectDimensionType> SelectDimension { get; set; }

    }
}