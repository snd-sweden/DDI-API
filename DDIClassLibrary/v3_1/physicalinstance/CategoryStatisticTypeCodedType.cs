using System;
using DDIClassLibrary.v3_1.reusable;

namespace DDIClassLibrary.v3_1.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class CategoryStatisticTypeCodedType : CodeValueType, IHaveDefaultValues
    {
        public CategoryStatisticTypeCodedType()
        {
            this.codeListAgencyName = "DDI";
            this.codeListID = "Category Statistic Type";
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