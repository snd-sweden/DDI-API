using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.physicaldataproduct;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_2")]
    public class TopLeftTableAnchorType
    {
        public TopLeftTableAnchorType()
        {            

        }

        [System.Xml.Serialization.XmlAttribute()]
        public string column { get; set; }

        private Nullable<int> _row;

        [System.Xml.Serialization.XmlAttribute()]
        public int row
        {
            get
            {
                if (_row.HasValue)
                    return _row.Value;
                return 0; //default value;
            }
            set
            {
                this._row = value;
            }
        }

        public bool ShouldSerializerow()
        {
            return _row.HasValue;
        }
    }
}