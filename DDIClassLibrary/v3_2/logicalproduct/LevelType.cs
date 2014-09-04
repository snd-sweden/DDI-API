using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class LevelType
    {
        public LevelType()
        {

        }

        private Nullable<int> _levelNumber;

        [System.Xml.Serialization.XmlAttribute()]
        public int levelNumber
        {
            get
            {
                if (_levelNumber.HasValue)
                    return _levelNumber.Value;
                return 0; //default value;
            }
            set
            {
                this._levelNumber = value;
            }
        }

        public bool ShouldSerializelevelNumber()
        {
            return _levelNumber.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public NameType LevelName { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CategoryRelationCodeType RelationshipType { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public IntervalType Interval { get; set; }
    }
}