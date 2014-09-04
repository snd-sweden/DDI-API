using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class SubCategoryReferenceType : ReferenceType
    {
        public SubCategoryReferenceType()
        {

        }

        private Nullable<SubCategoryType> _typeOfSubCategory;

        [System.Xml.Serialization.XmlAttribute()]
        public SubCategoryType typeOfSubCategory
        {
            get
            {
                if (_typeOfSubCategory.HasValue)
                    return _typeOfSubCategory.Value;
                return 0; //default value;
            }
            set
            {
                this._typeOfSubCategory = value;
            }
        }

        public bool ShouldSerializetypeOfSubCategory()
        {
            return _typeOfSubCategory.HasValue;
        }
    }
}