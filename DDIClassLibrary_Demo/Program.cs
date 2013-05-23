using System;
using System.IO;
using DDIClassLibrary;
using DDIClassLibrary.datacollection;
using DDIClassLibrary.instance;
using DDIClassLibrary.reusable;
using DDIClassLibrary.studyunit;

namespace DDIClassLibrary_Demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            DDIClassLibraryWrapper wrapper = new DDIClassLibraryWrapper();
            wrapper.AgencyID = "se.snd";
            wrapper.CreateURNs = true;
            wrapper.SetDefaultValues = true;

            DDIInstanceType instance = wrapper.DDIInstance;

            StudyUnitType s = new StudyUnitType();
            instance.StudyUnit.Add(s);

            s.Citation = new CitationType();
            s.Citation.Title.Add(new InternationalStringType("Title"));
            s.Citation.Title.Add(new InternationalStringType() { lang = "en", Content = "Test title" });
            s.Citation.Title.Add(new InternationalStringType() { lang = "sv", Content = "Title" });
            s.Citation.Creator.Add(new CreatorType("Johan Fihn"));

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

            s.SeriesStatement = new SeriesStatementType();
            s.SeriesStatement.Abbreviation.Add("test");

            s.KindOfData.Add(new KindOfDataType()
            {
                type = KindOfDataTypeType.Quantitative,
                Content = "My kind of data"
            });

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
                    Text = new System.Collections.Generic.List<TextType> ()
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
            }

            using (TextWriter writer = File.CreateText(@"C:\Users\johan\Desktop\ClassLibraryTest.xml"))
            {
                wrapper.Serialize(writer);
            }
        }
    }
}