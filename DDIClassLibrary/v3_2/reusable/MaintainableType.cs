using System;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
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
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        public virtual void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                this._isMaintainable = true;
            }
        }
    }
}