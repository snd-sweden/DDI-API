namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public enum DateTypeCodeType
    {
        DateTime,
        Date,
        Time,
        Year,
        Month,
        Day,
        MonthDay,
        YearMonth,
        Duration,
        Timespan
    }
}