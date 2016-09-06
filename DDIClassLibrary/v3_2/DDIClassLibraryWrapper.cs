using DDIClassLibrary.v3_2.instance;
using DDIClassLibrary.v3_2.reusable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DDIClassLibrary.v3_2
{
    public class DDIClassLibraryWrapper
    {
        #region Member Variables

        private DDIInstanceType _instance;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public DDIClassLibraryWrapper()
        {
            this.CreateURNs = false;
            this.SetDefaultValues = false;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DDIInstance.
        /// </summary>
        /// <value>
        /// The DDIInstance.
        /// </value>
        public DDIInstanceType DDIInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new DDIInstanceType();
                return _instance;
            }
            set
            {
                this._instance = value;
            }
        }

        /// <summary>
        /// Gets or sets the Agency ID.
        /// </summary>
        /// <value>
        /// The Agency ID.
        /// </value>
        public string AgencyID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether URNs should be generated automatically upon serialization.
        /// Property AgencyID must be set before serialization or an InvalidOperationException will be thrown.
        /// </summary>
        /// <value>
        ///   <c>true</c> if URNs should be generated; otherwise, <c>false</c>.
        /// </value>
        public bool CreateURNs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether optional default values should be set.
        /// </summary>
        /// <value>
        /// <c>true</c> if optional default values should be set; otherwise, <c>false</c>.
        /// </value>
        public bool SetDefaultValues { get; set; }

        #endregion Properties

        #region Functions

        #region Serialize functions

        /// <summary>
        /// Serializes the DDIInstance and writes the XML document to a string
        /// </summary>
        /// <returns>The DDIInstance serialized to a string</returns>
        public string Serialize()
        {
            using (StringWriter writer = new StringWriter())
            {
                Serialize(writer);

                return writer.ToString();
            }
        }

        /// <summary>
        /// Serializes the DDIInstance and writes the XML document to a file using the specified TextWriter.
        /// </summary>
        /// <param name="writer">The TextWriter used to write the XML document.</param>
        public void Serialize(TextWriter writer)
        {
            OnSerializingMethod();      

            XmlSerializer xs = new XmlSerializer(typeof(DDIInstanceType));
            xs.Serialize(writer, DDIInstance, GetXmlSerializerNamespaces());
        }

        /// <summary>
        /// Serializes the DDIInstance and writes the XML document to a file using the specified XmlWriter.
        /// </summary>
        /// <param name="writer">The XmlWriter used to write the XML document.</param>
        public void Serialize(XmlWriter writer)
        {
            OnSerializingMethod();

            XmlSerializer xs = new XmlSerializer(typeof(DDIInstanceType));
            xs.Serialize(writer, DDIInstance, GetXmlSerializerNamespaces());
        }

        /// <summary>
        /// Serializes the DDIInstance and writes the XML document to a file using the specified Stream.
        /// </summary>
        /// <param name="stream">The Stream used to write the XML document.</param>
        public void Serialize(Stream stream)
        {
            OnSerializingMethod();

            XmlSerializer xs = new XmlSerializer(typeof(DDIInstanceType));
            xs.Serialize(stream, DDIInstance, GetXmlSerializerNamespaces());
        }

        /// <summary>
        /// Serializes the DDIInstance and writes the XML document to a file using the specified XmlWriter and encoding style.
        /// </summary>
        /// <param name="writer">The XmlWriter used to write the XML document.</param>
        /// <param name="encoding">The encoding style of the serialized XML.</param>
        public void Serialize(XmlWriter writer, string encoding)
        {
            OnSerializingMethod();

            XmlSerializer xs = new XmlSerializer(typeof(DDIInstanceType));
            xs.Serialize(writer, DDIInstance, GetXmlSerializerNamespaces(), encoding);
        }

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">If CreateURNs is set to true, AgencyID must be set before serialization.</exception>
        internal void OnSerializingMethod()
        {
            if (CreateURNs)
            {
                if (String.IsNullOrEmpty(AgencyID))
                    throw new InvalidOperationException("If CreateURNs is set to true, AgencyID must be set before serialization.");
                CreateElementURNs(DDIInstance, null, null, null);
            }

            if (SetDefaultValues)
                SetElementDefaultValues(DDIInstance);
        }

        #endregion Serialize functions

        #region Deserialize functions

        /// <summary>
        /// Deserializes the XML document with the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public void Deserialize(string filename)
        {
            Stream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = new XmlTextReader(fs);
            XmlSerializer serializer = new XmlSerializer(typeof(DDIInstanceType));
            if (serializer.CanDeserialize(reader))
            {
                this.DDIInstance = (DDIInstanceType)serializer.Deserialize(reader);
            }
            fs.Close();
        }

        /// <summary>
        /// Deserializes the XML document contained by the specified Stream.
        /// </summary>
        /// <param name="stream">The Stream that contains the XML document to deserialize.</param>
        public void Deserialize(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DDIInstanceType));
            this.DDIInstance = (DDIInstanceType)serializer.Deserialize(stream);
        }

        /// <summary>
        /// Deserializes the XML document contained by the specified TextReader.
        /// </summary>
        /// <param name="reader">The TextReader that contains the XML document to deserialize.</param>
        public void Deserialize(TextReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DDIInstanceType));
            this.DDIInstance = (DDIInstanceType)serializer.Deserialize(reader);
        }

        /// <summary>
        /// Deserializes the XML document contained by the specified XmlReader.
        /// </summary>
        /// <param name="reader">The XmlReader that contains the XML document to deserialize.</param>
        public void Deserialize(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DDIInstanceType));
            if (serializer.CanDeserialize(reader))
                this.DDIInstance = (DDIInstanceType)serializer.Deserialize(reader);
        }

        /// <summary>
        /// Deserializes the XML document contained by the specified XmlReader and encoding style.
        /// </summary>
        /// <param name="reader">The XmlReader that contains the XML document to deserialize.</param>
        /// <param name="encodingStyle">The encoding style of the serialized XML.</param>
        public void Deserialize(XmlReader reader, string encodingStyle)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DDIInstanceType));
            if (serializer.CanDeserialize(reader))
                this.DDIInstance = (DDIInstanceType)serializer.Deserialize(reader, encodingStyle);
        }

        #endregion Deserialize functions

        #region Validation functions

        /// <summary>
        /// Validates the DDIInstance
        /// </summary>
        /// <returns>Returns a list with validation errors</returns>
        public List<string> Validate()
        {
            List<string> validationErrors = new List<string>();
            string Format = "Line: {0}, Position: {1} \"{2}\"";

            string xml;
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DDIInstanceType));
                serializer.Serialize(writer, DDIInstance);
                xml = writer.ToString();
            }

            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += (o, e) =>
            {
                validationErrors.Add(string.Format(Format,
                                        e.Exception.LineNumber,
                                        e.Exception.LinePosition,
                                        e.Exception.Message));
            };
            settings.Schemas.Add(null, "Schemas/instance.xsd");

            using (TextReader sr = new StringReader(xml))
            {
                using (XmlReader reader = XmlReader.Create(sr, settings))
                {
                    while (reader.Read()) ;
                }
            }

            return validationErrors;
        }
        
        #endregion Validation functions

        #region Private functions

        /// <summary>
        /// Recursive function which creates URNs for all maintainables, versionables and identifiables.
        /// </summary>
        /// <param name="o">The element to test and create an URN for.</param>
        /// <param name="maintainable">The parent maintainable.</param>
        /// <param name="maintainableID">The parent maintainable ID.</param>
        /// <param name="maintainableVersion">The parent maintainable version.</param>
        private void CreateElementURNs(object o, string maintainable, string maintainableID, string maintainableVersion)
        {
            //TODO CreateElementURNs
            /*

            //if (!o.GetType().Namespace.StartsWith("DDIClassLibrary"))
            //    return;
            if (o.GetType().IsValueType || o is String || o is Enum)
                return;

            if (o is MaintainableType)
            {
                MaintainableType m = o as MaintainableType;
                m.CreateURN(AgencyID);
                maintainable = m.ObjectType;
                maintainableID = m.id;
                maintainableVersion = m.version;
            }
            else if (o is VersionableType)
                (o as VersionableType).CreateURN(AgencyID, maintainable, maintainableID, maintainableVersion);
            else if (o is IdentifiableType)
                (o as IdentifiableType).CreateURN(AgencyID, maintainable, maintainableID, maintainableVersion);

            foreach (var p in o.GetType().GetProperties())
            {
                if (o.GetType().IsGenericType)
                {
                    foreach (var v in o as IList)
                    {
                        CreateElementURNs(v, maintainable, maintainableID, maintainableVersion);
                    }
                }
                else
                {
                    Object propvalue = p.GetValue(o, null);

                    if (propvalue != null)
                    {
                        if (propvalue.GetType().IsGenericType && propvalue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                        {
                            foreach (var v in propvalue as IList)
                            {
                                CreateElementURNs(v, maintainable, maintainableID, maintainableVersion);
                            }
                        }
                        else
                        {
                            CreateElementURNs(propvalue, maintainable, maintainableID, maintainableVersion);
                        }
                    }
                }
            }
            */
        }

        /// <summary>
        /// Recursive function which sets all element´s default values.
        /// </summary>
        /// <param name="o">The o.</param>
        private void SetElementDefaultValues(object o)
        {
            if (o.GetType().IsValueType || o is String || o is Enum)
                return;

            if (o is IHaveDefaultValues)
                (o as IHaveDefaultValues).SetDefaultValues(true);

            foreach (var p in o.GetType().GetProperties())
            {
                if (o.GetType().IsGenericType)
                {
                    foreach (var v in o as IList)
                    {
                        SetElementDefaultValues(v);
                    }
                }
                else
                {
                    Object propvalue = p.GetValue(o, null);

                    if (propvalue != null)
                    {
                        if (propvalue.GetType().IsGenericType && propvalue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                        {
                            foreach (var v in propvalue as IList)
                            {
                                SetElementDefaultValues(v);
                            }
                        }
                        else
                        {
                            SetElementDefaultValues(propvalue);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Constructs a XmlSerializerNamespaces object containing the namespaces
        /// and schemaLocation needed for DDI 3.2.
        /// </summary>
        /// <returns>the XmlSerializerNamespaces object</returns>
        private static XmlSerializerNamespaces GetXmlSerializerNamespaces()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("ddi", "ddi:instance:3_2");
            ns.Add("a", "ddi:archive:3_2");
            ns.Add("c", "ddi:conceptualcomponent:3_2");
            ns.Add("cm", "ddi:comparative:3_2");
            ns.Add("d", "ddi:datacollection:3_2");
            ns.Add("dc", "ddi:dcelements:3_2");
            ns.Add("dc2", "http://purl.org/dc/elements/1.1/");
            ns.Add("dc_terms", "http://purl.org/dc/terms/");
            ns.Add("ds", "ddi:dataset:3_2");
            ns.Add("g", "ddi:group:3_2");
            ns.Add("l", "ddi:logicalproduct:3_2");
            ns.Add("m1", "ddi:physicaldataproduct_ncube_normal:3_2");
            ns.Add("m2", "ddi:physicaldataproduct_ncube_tabular:3_2");
            ns.Add("m3", "ddi:physicaldataproduct_ncube_inline:3_2");
            ns.Add("m4", "ddi:physicaldataproduct_proprietary:3_2");
            ns.Add("p", "ddi:physicaldataproduct:3_2");
            ns.Add("pi", "ddi:physicalinstance:3_2");
            ns.Add("pr", "ddi:ddiprofile:3_2");
            ns.Add("r", "ddi:reusable:3_2");
            ns.Add("s", "ddi:studyunit:3_2");
            ns.Add("xsi", System.Xml.Schema.XmlSchema.InstanceNamespace);

            return ns;
        }

        #endregion

        #endregion Functions
    }
}