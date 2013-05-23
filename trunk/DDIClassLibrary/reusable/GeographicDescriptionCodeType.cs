namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum GeographicDescriptionCodeType
    {
        Point,
        Polygon,
        Line,
        LinearRing
    }
}