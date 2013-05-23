using System;

namespace DDIClassLibrary.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class DDIMaintenanceAgencyIDType
    {
        public DDIMaintenanceAgencyIDType()
        {
        }

        public DDIMaintenanceAgencyIDType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string registryID { get; set; }

        [System.Xml.Serialization.XmlText()]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(DDIMaintenanceAgencyIDType content)
        {
            return content.Content;
        }

        public static implicit operator DDIMaintenanceAgencyIDType(string n)
        {
            return new DDIMaintenanceAgencyIDType(n);
        }

        public override bool Equals(object obj)
        {
            return this.Content == (string)obj;
        }

        public override int GetHashCode()
        {
            return this.Content.GetHashCode();
        }

        #endregion conversion

        #region unary

        public static DDIMaintenanceAgencyIDType operator +(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator -(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator !(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator ~(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator ++(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator --(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static bool operator true(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        public static bool operator false(DDIMaintenanceAgencyIDType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static DDIMaintenanceAgencyIDType operator +(DDIMaintenanceAgencyIDType content, string n)
        {
            return content.Content + n;
        }

        public static DDIMaintenanceAgencyIDType operator -(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator *(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator /(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator %(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator &(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator |(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator ^(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static DDIMaintenanceAgencyIDType operator <<(DDIMaintenanceAgencyIDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static DDIMaintenanceAgencyIDType operator >>(DDIMaintenanceAgencyIDType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(DDIMaintenanceAgencyIDType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(DDIMaintenanceAgencyIDType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(DDIMaintenanceAgencyIDType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}