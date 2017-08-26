using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUFL_I18N;

namespace UnitTestCRI18N
{
    [TestClass]
    public class TranslatorUnitTest
    {
        [TestMethod]
        public void TestGetTranslation()
        {
            Translator translator = new Translator();
            string json = @"{'Translations' :[ {'Key':'Hello','Value':'Bonjour'},{'Key':'Title','Value':'My Report'} ]}";
          

             string label = translator.GetTranslation("Hello", json);
            Console.WriteLine(label);

            Assert.AreEqual(label, "Bonjour");

        }

        [TestMethod]
        public void TestGetTranslationNotFound()
        {
            Translator translator = new Translator();
            string json = @"{'Translations' :[ {'Key':'Title','Value':'My Report'} ]}";


            string label = translator.GetTranslation("Hello", json);
            Console.WriteLine(label);

            Assert.AreEqual(label, "Hello");

        }
    }
}
