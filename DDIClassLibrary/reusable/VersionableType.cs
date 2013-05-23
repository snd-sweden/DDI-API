using System;
namespace DDIClassLibrary.reusable
{
    public abstract class VersionableType : AbstractVersionableType, IHaveDefaultValues
    {
        private Nullable<bool> _isVersionable;

        [System.Xml.Serialization.XmlAttribute()]
        public bool isVersionable
        {
            get
            {
                return true;
            }
            set
            {
                if (value == false)
                    this._isVersionable = null;
                else this._isVersionable = true;
            }
        }

        public bool ShouldSerializeisVersionable()
        {
            if (_isVersionable.HasValue)
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
                !String.IsNullOrEmpty(maintainableVersion) && !String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(version))
            {
                this.urn = "urn:ddi:" + agencyID + ":" + maintainable + "." + maintainableID + "." + maintainableVersion +
                           ":" + ObjectType + "." + id + "." + version;
            }
        }

        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public void SetDefaultValues(bool shouldSet)
        {
            if(shouldSet)
                this.isVersionable = true;
        }
    }
}