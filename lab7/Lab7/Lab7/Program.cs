using System;
using System.Collections.Generic;
using System.Threading;
namespace Lab7
{
    class Program
    {
        private const int AMOUNT_THREADS = 4;
        static DateTime start;
        static DateTime finish;
        static TimeSpan difference;
        static double result;
        static Dictionary<string, double> values = new Dictionary<string, double>();
        static List<Thread> threads = new List<Thread>();
        static void Main(string[] args)
        {
            Program.start = DateTime.Now;
            CreateThreads(AMOUNT_THREADS);
            foreach (Thread t in threads)
            {
                t.Start();
            }
            

            foreach (Thread t in threads)
            {
                t.Join();
            }


            foreach (KeyValuePair<string, double> entry in values)
            {
                result += entry.Value;
            }

            finish = DateTime.Now;
            Console.WriteLine("Difference:{0}", (finish - start).Milliseconds);
            double avarage = result / AMOUNT_THREADS;
            Console.WriteLine("Result:{0}", avarage);

            foreach (KeyValuePair<string, double> entry in values)
            {
                Console.WriteLine("Index:{0} Value:{1}", entry.Key, entry.Value);
            }


            Console.ReadKey();
        }

        private static void CreateThreads(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                threads.Add(new Thread(Calculate));
            }
        }

        private static void Calculate(object obj)
        {
            Random rnd = new Random();
            int amount = rnd.Next(10000, 1000000);
            double v = MonteCarlo.Calculate(amount);
            values.Add(Guid.NewGuid().ToString(), v);
        }
    }
}
