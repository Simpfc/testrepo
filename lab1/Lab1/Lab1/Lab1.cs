using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Lab1
    {
        private string[] getData()
        {
            string [] list = new string[7] {
                "string one",
                "string one plus two",
                "string three plus some string",
                "string number four some extra string",
                "it's five",
                "it's five or six",
                "it's five or six or seven",
            };
            return list;
        }

        public int CalculateAvarageOfSymbols(string[] array)
        {
            int total = 0;

            foreach (string str in array)
            {
                total += str.Length;
            }

            float avarage = total / array.Length;
            return Convert.ToInt32(avarage); ;
        }

        private Boolean IsStringLessThen(string s, int n)
        {
            return s.Length < n;
        }

        public string[] getStringsLengthLessThen(int avarage, string[] data)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < data.Length; i++)
            {
                if (IsStringLessThen(data[i], avarage))
                {
                    list.Add(data[i]);
                }
            }

            return list.ToArray();
        }
    }
}
