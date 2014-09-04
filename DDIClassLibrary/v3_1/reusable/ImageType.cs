using System;

namespace DDIClassLibrary.v3_1.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_1")]
    public class ImageType
    {
        public ImageType()
        {
        }

        public ImageType(string content)
        {
            this.Content = content;
        }

        [System.Xml.Serialization.XmlAttribute()]
        public int dpi { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        [System.Xml.Serialization.XmlText(DataType = "anyURI")]
        public string Content { get; set; }

        #region conversion

        public static implicit operator string(ImageType content)
        {
            return content.Content;
        }

        public static implicit operator ImageType(string n)
        {
            return new ImageType(n);
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

        public static ImageType operator +(ImageType content)
        {
            throw new Exception();
        }

        public static ImageType operator -(ImageType content)
        {
            throw new Exception();
        }

        public static ImageType operator !(ImageType content)
        {
            throw new Exception();
        }

        public static ImageType operator ~(ImageType content)
        {
            throw new Exception();
        }

        public static ImageType operator ++(ImageType content)
        {
            throw new Exception();
        }

        public static ImageType operator --(ImageType content)
        {
            throw new Exception();
        }

        public static bool operator true(ImageType content)
        {
            throw new Exception();
        }

        public static bool operator false(ImageType content)
        {
            throw new Exception();
        }

        #endregion unary

        #region binary

        public static ImageType operator +(ImageType content, string n)
        {
            return content.Content + n;
        }

        public static ImageType operator -(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator *(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator /(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator %(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator &(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator |(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator ^(ImageType content, string n)
        {
            throw new Exception();
        }

        public static ImageType operator <<(ImageType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(n);
        }

        public static ImageType operator >>(ImageType content, int n)
        {
            if (content.Content.Length < n) return String.Empty;
            return content.Content.Substring(0, content.Content.Length - n);
        }

        #endregion binary

        #region comparison

        public static bool operator ==(ImageType content, string n)
        {
            return content.Content == n;
        }

        public static bool operator !=(ImageType content, string n)
        {
            return content.Content != n;
        }

        public static bool operator <(ImageType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >(ImageType content, string n)
        {
            throw new Exception();
        }

        public static bool operator <=(ImageType content, string n)
        {
            throw new Exception();
        }

        public static bool operator >=(ImageType content, string n)
        {
            throw new Exception();
        }

        #endregion comparison
    }
}