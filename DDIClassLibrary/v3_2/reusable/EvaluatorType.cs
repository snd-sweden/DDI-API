using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class EvaluatorType
    {
        public EvaluatorType()
        {
            this.EvaluatorRole = new List<CodeValueType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public ReferenceType EvaluatorReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<CodeValueType> EvaluatorRole { get; set; }

    }
}
