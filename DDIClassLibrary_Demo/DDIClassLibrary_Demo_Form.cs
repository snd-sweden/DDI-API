using DDIClassLibrary.v3_2;
using DDIClassLibrary.v3_2.datacollection;
using DDIClassLibrary.v3_2.instance;
using DDIClassLibrary.v3_2.logicalproduct;
using DDIClassLibrary.v3_2.reusable;
using DDIClassLibrary.v3_2.studyunit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

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
                s.Citation.Title = new InternationalStringType();
                s.Citation.Title.String.Add(new StringType() { lang = "en", Content = "Test title" });
                s.Citation.Title.String.Add(new StringType() { lang = "sv", Content = "Title" });

                CreatorType creator = new CreatorType();
                creator.CreatorName = new BibliographicNameType();
                creator.CreatorName.String.Add(new StringType("Johan Fihn"));
                s.Citation.Creator.Add(creator);
            }

            //Abstract
            {
                s.Abstract = new StructuredStringType();
                s.Abstract.Content.Add(new ContentType("Beskrivning", "sv"));
                s.Abstract.Content.Add(new ContentType("Abstract", "en"));
            }

            //SeriesStatement
            {
                SeriesStatementType series = new SeriesStatementType();

                series.SeriesName.Add(new NameType("Min serie", "sv"));
                series.SeriesName.Add(new NameType("My series", "en"));

                s.SeriesStatement.Add(series);
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

                    DynamicTextType text = new DynamicTextType();
                    text.TextContent.Add(new LiteralTextType() { Text = new TextType() { Content = "Fråga #" + i, lang = "sv" } });
                    qi.QuestionText.Add(text);

                    text = new DynamicTextType();
                    text.TextContent.Add(new LiteralTextType() { Text = new TextType() { Content = "Question #" + i, lang = "en" } });
                    qi.QuestionText.Add(text);

                    VariableType var = new VariableType();
                    var.VariableName.Add(new NameType("Variabel #" + i, "sv"));
                    var.VariableName.Add(new NameType("Variable #" + i, "en"));

                    vs.Variable.Add(var);
                }
            }

            using (TextWriter writer = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ClassLibraryTest.xml"))
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
