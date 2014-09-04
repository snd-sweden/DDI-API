namespace DDIClassLibrary.v3_1.physicaldataproduct_ncube_tabular
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:physicaldataproduct_ncube_tabular:3_1")]
    public class TopLeftTableAnchorType
    {
        public TopLeftTableAnchorType()
        {
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int column { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public int row { get; set; }
    }
}