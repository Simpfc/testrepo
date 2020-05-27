using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace Lab5.Tests
{
    public class Tests
    {
        private string path = "/Users/andriipasholka/kpi/disciplines/smitrpz/labs/Lab5/input.txt";
        private string pathOut = "/Users/andriipasholka/kpi/disciplines/smitrpz/labs/Lab5/output.txt";
        private Lab5 handler;

        [SetUp]
        public void Setup()
        {
            this.handler = new Lab5(this.path, this.pathOut);
        }

        [Test]
        public void TestGetContentFromFile()
        {
            string content = handler.GetContentFromFile();
            Assert.IsTrue(content is string, "Content should be string");

            List<string> collection = handler.ParceContentBySeparator(content, ".");
            int count = collection.Count();
            Assert.AreEqual(32, count);

            int maxLengthRow = handler.GetIndexOfMaxLengthfRow(collection);
            Assert.AreEqual(22, maxLengthRow);

            if (File.Exists(this.pathOut))
            {
                File.Delete(this.pathOut);
            }

            StreamWriter sw = File.AppendText(this.pathOut);
            handler.WriteRowsIntoFileRecursively(sw, collection);
            sw.Close();
        }
    }
}