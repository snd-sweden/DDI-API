using DDIClassLibrary.reusable;

namespace DDIClassLibrary.physicalinstance
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicalinstance:3_1")]
    public class SummaryStatisticTypeCodedType : CodeValueType
    {
        public SummaryStatisticTypeCodedType()
        {
            this.codeListAgencyName = "DDI";
            this.codeListID = "Summary Statistic Type";
            this.codeListVersionID = "1.0";
        }
    }
}