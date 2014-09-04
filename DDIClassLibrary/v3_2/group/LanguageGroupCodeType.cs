namespace DDIClassLibrary.v3_2.group
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:group:3_2")]
    public enum LanguageGroupCodeType
    {
        /// <summary>
        /// No formal relationship - not a factor of grouping
        /// </summary>
        L0,

        /// <summary>
        /// Single language
        /// </summary>
        L1,

        /// <summary>
        /// All original languages with full language equivalence
        /// </summary>
        L2,

        /// <summary>
        /// Original language(s) plus translation(s) with full language equivalence
        /// </summary>
        L3,

        /// <summary>
        /// Translations from external original; full language equivalence
        /// </summary>
        L4,

        /// <summary>
        /// Translations from a non-included original and have full language equivalence
        /// </summary>
        L5,

        /// <summary>
        /// Original languages(s) plus translation(s) with partial relationship
        /// </summary>
        L6,

        /// <summary>
        /// Translations from external original; partial relationships
        /// </summary>
        L7
    }
}