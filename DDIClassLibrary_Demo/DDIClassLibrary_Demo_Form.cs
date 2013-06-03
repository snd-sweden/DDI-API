using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDIClassLibrary;
using DDIClassLibrary.datacollection;
using DDIClassLibrary.instance;
using DDIClassLibrary.logicalproduct;
using DDIClassLibrary.reusable;
using DDIClassLibrary.studyunit;

namespace DDIClassLibrary_Demo
{
    public partial class DDIClassLibrary_Demo_Form : Form
    {
        public DDIClassLibrary_Demo_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DDIClassLibraryWrapper wrapper = new DDIClassLibraryWrapper();
            wrapper.AgencyID = "se.snd";
            wrapper.CreateURNs = false;
            wrapper.SetDefaultValues = false;

            DDIInstanceType instance = wrapper.DDIInstance;

            StudyUnitType s = new StudyUnitType();
            instance.StudyUnit.Add(s);

            //Citation
            {
                s.Citation = new CitationType();
                s.Citation.Title.Add(new InternationalStringType("Title"));
                s.Citation.Title.Add(new InternationalStringType() { lang = "en", Content = "Test title" });
                s.Citation.Title.Add(new InternationalStringType() { lang = "sv", Content = "Title" });
                s.Citation.Creator.Add(new CreatorType("Johan Fihn"));
            }

            //Abstract
            {
                s.Abstract.Add(new IdentifiedStructuredStringType()
                {
                    Content = new StructuredStringType()
                    {
                        lang = "sv",
                        Content = "Beskrivning"
                    }
                });

                s.Abstract.Add(new IdentifiedStructuredStringType()
                {
                    Content = new StructuredStringType()
                    {
                        lang = "en",
                        Content = "Abstract"
                    }
                });
            }

            //SeriesStatement
            {
                s.SeriesStatement = new SeriesStatementType();
                s.SeriesStatement.SeriesName.Add(new NameType()
                {
                    lang = "sv",
                    Content = "Min serie"
                });
                s.SeriesStatement.SeriesName.Add(new NameType()
                {
                    lang = "en",
                    Content = "My series"
                });
                s.SeriesStatement.Abbreviation.Add("test");
            }

            //KindOfData
            {
                s.KindOfData.Add(new KindOfDataType()
                {
                    type = KindOfDataTypeType.Quantitative,
                    Content = "My kind of data"
                });
            }

            //LogicalProduct
            LogicalProductType lp = new LogicalProductType();
            s.BaseLogicalProduct.Add(lp);

            VariableSchemeType vs = new VariableSchemeType();
            lp.VariableScheme.Add(vs);

            //DataCollection
            {
                DataCollectionType dc = new DataCollectionType();
                s.DataCollection.Add(dc);

                QuestionSchemeType qs = new QuestionSchemeType();
                dc.QuestionScheme.Add(qs);

                for (int i = 1; i <= 10; i++)
                {
                    QuestionItemType qi = new QuestionItemType();
                    qs.QuestionItem.Add(qi);
                    qi.QuestionText.Add(new DynamicTextType()
                    {
                        lang = "sv",
                        Text = new System.Collections.Generic.List<TextType>()
                    {
                        new LiteralTextType()
                        {
                            Text = "Fråga #" + i,
                        }
                    }
                    });
                    qi.QuestionText.Add(new DynamicTextType()
                    {
                        lang = "en",
                        Text = new System.Collections.Generic.List<TextType>()
                    {
                        new LiteralTextType()
                        {
                            Text = "Question #" + i,
                        }
                    }
                    });

                    VariableType var = new VariableType();
                    var.VariableName.Add(new NameType()
                    {
                        lang = "sv",
                        Content = "Variabel #" + i
                    });
                    var.VariableName.Add(new NameType()
                    {
                        lang = "en",
                        Content = "Variable #" + i
                    });
                    var.QuestionReference.Add(new ReferenceType(qi));
                    vs.Variable.Add(var);
                }
            }

            foreach (string error in wrapper.Validate())
            {
                Console.WriteLine(error);
                Console.Read();
            }

            using (TextWriter writer = File.CreateText(@"C:\Users\johan\Desktop\ClassLibraryTest.xml"))
            {
                wrapper.Serialize(writer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DDIClassLibraryWrapper wrapper = new DDIClassLibraryWrapper();
                wrapper.Deserialize(dialog.FileName);

                wrapper.ToString();
            }
        }
    }
}
