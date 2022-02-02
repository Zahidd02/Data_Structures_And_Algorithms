using System;
using System.Collections.Generic;
using System.Linq;

namespace Temporary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("a", "A");
            dictionary.Add("b", "B");
            dictionary.Add("c", "C");
            dictionary.Add("d", "D");
            dictionary.Add("e", "E");
            dictionary.Add("f", "F");
            dictionary.Add("g", "G");

            dictionary["0"] = "lll";

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }
           
        }
    }
}
