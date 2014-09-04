namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class BoundingBoxType
    {
        public BoundingBoxType()
        {
        }

        private double _westLongitude;

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public double WestLongitude
        {
            get { return this._westLongitude; }
            set
            {
                if (value < -180 || value > 180)
                    throw new System.ArgumentException("value is outside of range");
                this._westLongitude = value;
            }
        }

        private double _eastLongitude;

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public double EastLongitude
        {
            get { return this._eastLongitude; }
            set
            {
                if (value < -180 || value > 180)
                    throw new System.ArgumentException("value is outside of range");
                this._eastLongitude = value;
            }
        }

        private double _southLatitude;

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public double SouthLatitude
        {
            get { return this._southLatitude; }
            set
            {
                if (value < -90 || value > 90)
                    throw new System.ArgumentException("value is outside of range");
                this._southLatitude = value;
            }
        }

        private double _northLatitude;

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public double NorthLatitude
        {
            get { return this._northLatitude; }
            set
            {
                if (value < -90 || value > 90)
                    throw new System.ArgumentException("value is outside of range");
                this._northLatitude = value;
            }
        }
    }
}