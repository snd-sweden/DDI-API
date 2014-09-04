using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class ExPostEvaluationType
    {
        public ExPostEvaluationType()
        {
            this.TypeOfEvaluation = new List<CodeValueType>();
            this.Evaluator = new List<EvaluatorType>();
            this.EvaluationProcess = new List<StructuredStringType>();
            this.Outcomes = new List<StructuredStringType>();
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string completionDate { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<CodeValueType> TypeOfEvaluation { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<EvaluatorType> Evaluator { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<StructuredStringType> EvaluationProcess { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<StructuredStringType> Outcomes { get; set; }
    }
}
