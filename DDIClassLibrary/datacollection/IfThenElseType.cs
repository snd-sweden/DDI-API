using System.Collections.Generic;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class IfThenElseType : ControlConstructType
    {
        public IfThenElseType()
        {
            this.ObjectType = "IfThenElse";
            
            this.ElseIf = new List<ElseIfType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CodeType IfCondition { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ReferenceType ThenConstructReference { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<ElseIfType> ElseIf { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public ReferenceType ElseConstructReference { get; set; }
    }
}