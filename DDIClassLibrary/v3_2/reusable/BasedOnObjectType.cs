using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class BasedOnObjectType
    {
        public BasedOnObjectType()
        {
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> BasedOnReference { get; set; }
    
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public InternationalStringType BasedOnRationaleDescription { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CodeValueType BasedOnRationaleCode { get; set; }
    }
}