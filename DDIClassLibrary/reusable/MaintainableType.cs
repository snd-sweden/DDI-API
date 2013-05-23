using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public abstract class MaintainableType : AbstractMaintainableType, IHaveDefaultValues
    {
        private Nullable<bool> _isMaintainable;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isMaintainable
        {
            get
            {
                return true;
            }
            set
            {
                if (value == false)
                    this._isMaintainable = null;
                else this._isMaintainable = true;
            }
        }

        public bool ShouldSerializeisMaintainable()
        {
            if (_isMaintainable.HasValue)
                return true;
            return false;
        }

        /// <summary>
        /// Generates an URN for the maintainable.
        /// </summary>
        /// <param name="agencyID">The agency ID.</param>
        /// <exception cref="System.ArgumentException">ObjectType not set</exception>
        internal virtual void CreateURN(string agencyID)
        {   
            if (String.IsNullOrEmpty(ObjectType))
                throw new ApplicationException("ObjectType not set");

            if (String.IsNullOrEmpty(this.urn) && (!String.IsNullOrEmpty(agency) || !String.IsNullOrEmpty(agencyID)) && !String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(version))
            {
                this.urn = "urn:ddi:";
                this.urn += String.IsNullOrEmpty(agency) ? agencyID : agency;
                this.urn += ":" + ObjectType + "." + id + "." + version;
            }
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                this._isMaintainable = true;
            }
        }
    }
}