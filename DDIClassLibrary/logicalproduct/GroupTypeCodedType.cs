using System;
using DDIClassLibrary.reusable;

namespace DDIClassLibrary.logicalproduct
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:logicalproduct:3_1")]
    public class GroupTypeCodedType : CodeValueType, IHaveDefaultValues
    {
        public GroupTypeCodedType()
        {
            this.codeListAgencyName = "DDI";
            this.codeListID = "Group Type";
        }

        /// <summary>
        /// Sets the default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c> [should set].</param>
        public new void SetDefaultValues(bool shouldSet)
        {
            if (shouldSet)
            {
                base.SetDefaultValues(shouldSet);
                if (String.IsNullOrEmpty(codeListVersionID)) codeListVersionID = "1.0";
            }
        }
    }
}