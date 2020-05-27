using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    public class Lab5
    {
        private string pathToInputFile;
        private string pathToOutputFile;

        public Lab5(string pathToInputFile, string pathToOutputFile)
        {
            if (!File.Exists(pathToInputFile))
            {
                throw new FileLoadException();
            }

            this.pathToInputFile = pathToInputFile;
            this.pathToOutputFile = pathToOutputFile;
        }

        public string GetContentFromFile()
        {
            string readText = File.ReadAllText(this.pathToInputFile);

            return readText;
        }

        public List<string> ParceContentBySeparator(string content, string separator)
        {
            string[] words = content.Split(separator);
            List<string> collection = new List<string>();

            foreach (string str in words)
            {
                if (str.Length == 0)
                {
                    continue;
                }

                collection.Add(str);
            }

            return collection;
        }

        public void WriteRowsIntoFileRecursively(StreamWriter sw, List<string> collection)
        {
            int indexOfMaxLengthRow = GetIndexOfMaxLengthfRow(collection);
            string strMaxLengthRow = collection.ElementAt(indexOfMaxLengthRow);

            sw.WriteLine(strMaxLengthRow);
            collection.RemoveAt(indexOfMaxLengthRow);

            if (collection.Count() > 0)
            {
                WriteRowsIntoFileRecursively(sw, collection);
            }
        }

        public int GetIndexOfMaxLengthfRow(List<string> colection)
        {
            int maxLength = 0;
            int indexOfMaxLengthRow = -1;

            for (int i = 0; i < colection.Count(); i++)
            {
                string str = colection.ElementAt(i);
                int length = str.Length;

                if (length > maxLength)
                {
                    maxLength = length;
                    indexOfMaxLengthRow = i;
                }
            }


            return indexOfMaxLengthRow;
        }
    }    
}
