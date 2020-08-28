using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            string line;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                input.Add(line);
            }

            FindDoubleChar(input);

            Console.ReadKey();
        }


        public static void FindDoubleChar(List<string> input)
        {
            
            foreach (var str in input)
            {
                char[] chrs= str.OrderBy(c => c).ToArray();

                var queue = chrs.Distinct();
                Dictionary<char, int> lst = new Dictionary<char, int>();

                //search for duplicated chars
                foreach (var ch in queue)
                {
                    lst.Add(ch, str.Count(c => c == ch)); 
                }

                //output only char appears exactly two times
                if (lst.ContainsValue(2))
                {
                    Console.WriteLine(str + "");
                }
            }
        }
    }
}
