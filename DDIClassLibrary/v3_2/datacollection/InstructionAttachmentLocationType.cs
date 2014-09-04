using System.Collections.Generic;
using DDIClassLibrary.v3_2.reusable;
using System;

namespace DDIClassLibrary.v3_2.datacollection
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "ddi:datacollection:3_2")]
    public class InstructionAttachmentLocationType
    {
        public InstructionAttachmentLocationType()
        {
            this.AttachmentLocation = new List<AttachmentLocationType>();
            this.GridAttachment = new List<GridAttachmentType>();
        }

        private Nullable<bool> _attachToLabel;

        [System.Xml.Serialization.XmlAttribute()]
        public bool attachToLabel
        {
            get
            {
                if (_attachToLabel.HasValue)
                    return _attachToLabel.Value;
                return false; //default value;
            }
            set
            {
                this._attachToLabel = value;
            }
        }

        public bool ShouldSerializeattachToLabel()
        {
            return _attachToLabel.HasValue;
        }

        private Nullable<bool> _attachToQuestionText;

        [System.Xml.Serialization.XmlAttribute()]
        public bool attachToQuestionText
        {
            get
            {
                if (_attachToQuestionText.HasValue)
                    return _attachToQuestionText.Value;
                return false; //default value;
            }
            set
            {
                this._attachToQuestionText = value;
            }
        }

        public bool ShouldSerializeattachToQuestionText()
        {
            return _attachToQuestionText.HasValue;
        }

        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public List<AttachmentLocationType> AttachmentLocation { get; set; }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public List<GridAttachmentType> GridAttachment { get; set; }

    }
}