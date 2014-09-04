using System;
using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    public class NameType : InternationalStringType
    {

        public NameType()
        {
        }

        public NameType(string content)
            : base(content)
        {
        }

        public NameType(string content, string lang)
            : base (content, lang)
        {            
        }

        private Nullable<bool> _isPreferred;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isPreferred
        {
            get
            {
                return true;
            }
            set
            {
                if (value == false)
                    this._isPreferred = null;
                else this._isPreferred = true;
            }
        }

        public bool ShouldSerializeisPreferred()
        {
            if (_isPreferred.HasValue)
                return true;
            return false;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string context { get; set; }
    }
}