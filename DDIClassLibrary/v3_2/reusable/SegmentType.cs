using System.Collections.Generic;

namespace DDIClassLibrary.v3_2.reusable
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:reusable:3_2")]
    public class SegmentType
    {
        public SegmentType()
        {
            this.Audio = new List<AudioType>();
            this.ImageArea = new List<ImageAreaType>();
            this.Textual = new List<TextualType>();
            this.Video = new List<VideoType>();
            this.XML = new List<string>();
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<TextualType> Textual { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 1)]
        public List<AudioType> Audio { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 2)]
        public List<VideoType> Video { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 3)]
        public List<string> XML { get; set; }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 4)]
        public List<ImageAreaType> ImageArea { get; set; }
    }
}