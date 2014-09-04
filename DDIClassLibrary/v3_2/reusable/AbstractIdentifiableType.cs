using System;
using System.Collections.Generic;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public abstract class AbstractIdentifiableType
    {
        public AbstractIdentifiableType()
        {
            this.UserID = new System.Collections.Generic.List<UserIDType>();
        }

        private Nullable<ActionCodeType> _inheritanceAction;

        [System.Xml.Serialization.XmlAttribute()]
        public ActionCodeType inheritanceAction
        {
            get
            {
                if (_inheritanceAction.HasValue)
                    return _inheritanceAction.Value;
                return ActionCodeType.Add;
            }
            set
            {
                this._inheritanceAction = value;
            }
        }

        public bool ShouldSerializeinheritanceAction()
        {
            return _inheritanceAction.HasValue;
        }
        
        [System.Xml.Serialization.XmlAttribute()]
        public string objectSource { get; set; }

        private Nullable<UniquenessScopeType> _scopeOfUniqueness;

        [System.Xml.Serialization.XmlAttribute()]
        public UniquenessScopeType scopeOfUniqueness
        {
            get
            {
                if (_scopeOfUniqueness.HasValue)
                    return _scopeOfUniqueness.Value;
                return UniquenessScopeType.Agency; //default value;
            }
            set
            {
                this._scopeOfUniqueness = value;
            }
        }

        public bool ShouldSerializescopeOfUniqueness()
        {
            return _scopeOfUniqueness.HasValue;
        }

        private Nullable<bool> _isUniversallyUnique;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isUniversallyUnique
        {
            get
            {
                if (_isUniversallyUnique.HasValue)
                    return _isUniversallyUnique.Value;
                return true;
            }
            set
            {
                this._isUniversallyUnique = value;
            }
        }

        public bool ShouldSerializeisUniversallyUnique()
        {
            return _isUniversallyUnique.HasValue;
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string URN { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Agency { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string ID { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string Version { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<UserIDType> UserID { get; set; }

    }
}