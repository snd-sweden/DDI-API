using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
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
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public virtual void SetDefaultValues(bool shouldSet)
        {
            if(shouldSet)
                this.isVersionable = true;
        }
    }
}