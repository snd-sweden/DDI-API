using System;
using System.Collections.Generic;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_1")]
    public class GenerationInstructionType : IHaveDefaultValues
    {
        public GenerationInstructionType()
        {
            this.SourceQuestion = new List<SourceReferenceType>();
            this.SourceVariable = new List<SourceReferenceType>();
            this.ExternalInformation = new List<OtherMaterialType>();
            this.Description = new List<StructuredStringType>();
            this.Command = new List<CommandType>();
            this.ControlConstructReference = new List<ReferenceType>();
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

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<SourceReferenceType> SourceQuestion { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<SourceReferenceType> SourceVariable { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<OtherMaterialType> ExternalInformation { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = false, Order = 3)]
        public List<StructuredStringType> Description { get; set; }

        [System.Xml.Serialization.XmlElement(Namespace = "ddi:reusable:3_1", IsNullable = true, Order = 4)]
        public List<CommandType> Command { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 5)]
        public List<ReferenceType> ControlConstructReference { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public AggregationType Aggregation { get; set; }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                if (!this._isDerived.HasValue) this._isDerived = true;
            }
        }
    }
}