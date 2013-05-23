using System;
namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public abstract class IdentifiableType : AbstractIdentifiableType, IHaveDefaultValues
    {
        private Nullable<bool> _isIdentifiable;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isIdentifiable 
        { 
            get 
            { 
                return true; 
            } 
            set 
            {
                if (value == false)
                    this._isIdentifiable = null;
                else this._isIdentifiable = true; 
            } 
        }

        public bool ShouldSerializeisIdentifiable()
        {
            if (_isIdentifiable.HasValue)
                return true;
            return false;
        }

        /// <summary>
        /// Generates an URN for the versionable.
        /// </summary>
        /// <param name="agencyID">The agency ID.</param>
        /// <exception cref="System.ArgumentException">ObjectType not set</exception>
        internal virtual void CreateURN(string agencyID, string maintainable, string maintainableID, string maintainableVersion)
        {
            if (String.IsNullOrEmpty(ObjectType))
                throw new ApplicationException("ObjectType not set");

            if (String.IsNullOrEmpty(this.urn) && !String.IsNullOrEmpty(agencyID) &&
                !String.IsNullOrEmpty(maintainable) && !String.IsNullOrEmpty(maintainableID) &&
                !String.IsNullOrEmpty(maintainableVersion) && !String.IsNullOrEmpty(id))
            {
                this.urn = "urn:ddi:" + agencyID + ":" + maintainable + "." + maintainableID + "." + maintainableVersion +
                           ":" + ObjectType + "." + id + ".1.0.0";
            }
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                this.isIdentifiable = true;
            }
        }
    }
}