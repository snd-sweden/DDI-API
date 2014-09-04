using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class RequiredResourcePackagesType
    {
        public RequiredResourcePackagesType()
        {
            this.ResourcePackageReference = new List<ReferenceType>();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public List<ReferenceType> ResourcePackageReference { get; set; }   
      
    }
}