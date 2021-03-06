﻿using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;

namespace DDIClassLibrary.v3_2.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_2")]
    public class GenerationType : IHaveDefaultValues
    {
        public GenerationType()
        {
            this.ComponentReference = new List<ReferenceType>();
            this.CommandCode = new List<CommandCodeType>();
            this.OtherMaterial = new List<OtherMaterialType>();
        }

        private Nullable<bool> _isDerived;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isDerived
        {
            get
            {
                if (_isDerived.HasValue)
                    return _isDerived.Value;
                return true; //default value;
            }
            set
            {
                this._isDerived = value;
            }
        }

        public bool ShouldSerializeisDerived()
        {
            return _isDerived.HasValue;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string qualification { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<ReferenceType> ComponentReference { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", Order = 1)]
        public StructuredStringType Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 2)]
        public List<CommandCodeType> CommandCode { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_2", IsNullable = true, Order = 3)]
        public List<OtherMaterialType> OtherMaterial { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isDerived.HasValue) this._isDerived = true;
                if (String.IsNullOrEmpty(qualification)) qualification = "optional";
            }
        }
    }
}