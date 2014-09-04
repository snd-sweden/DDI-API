using System;
namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
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
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public virtual void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                this.isIdentifiable = true;
            }
        }
    }
}