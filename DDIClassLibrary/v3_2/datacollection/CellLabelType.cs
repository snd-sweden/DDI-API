using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class CellLabelType : LabelType
    {
        public CellLabelType()
        {
            this.GridAttachment = new List<GridAttachmentType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<GridAttachmentType> GridAttachment { get; set; }
    }
}