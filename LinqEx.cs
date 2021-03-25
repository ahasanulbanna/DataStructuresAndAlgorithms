using System;
using System.Linq;

namespace DataStructuresAndAlgorithmsPractices
{
    public class LinqEx
    {
        public string[] ar = { "hello", "wonderful", "LINQ", "beautiful", "world" };


        public void shortWord()
        {
            var query = from a in ar where a.Length < 6 select a;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

    }
}
