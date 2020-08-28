using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                //int counter = 1;
                char[] chrs= str.OrderBy(c => c).ToArray();

                var queue = chrs.Distinct();
                Dictionary<char, int> lst = new Dictionary<char, int>();

                foreach (var ch in queue)
                {
                    lst.Add(ch, str.Count(c => c == ch)); 
                    
                    Console.WriteLine("{0} repeating {1} times", ch, str.Count(c => c == ch));
                }

                if (lst.ContainsValue(2))
                {
                    Console.WriteLine(str + "");
                }

                //for (int i = 0; i < chrs.Length - 1;)
                //{
                //    if (chrs[i] == chrs[i + 1])
                //    {
                //        tmp = chrs[i + 1];
                //        doubleChar = tmp;

                //    }
                //    if (chrs[i + 1] == doubleChar)
                //    {

                //        counter++;
                //    }


                //}

                //if (counter == 2 && counter < 3)
                //{
                //    Console.WriteLine(str + "");
                //}
            }
        }
        public static void FindDoubleChar_1(string input)
        {
            char[] chars = input.OrderBy(c => c).ToArray();

            int counter = 1;
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                { counter++; }
            }


            if (counter == 2 && counter < 3)
            {
                Console.WriteLine($"word with repeated char twice: {input}");
            }
            else if (counter >= 3)
                Console.Write("Any character appears more than two times.");
            else
                Console.Write("No repeated characters");
        }

        public static void FindDoubleChar2(string str)
        {

            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;

                    }
                }
            }
            if (count == 2 && count < 3)
            {
                Console.WriteLine(str);
            }
            else if (count >= 3)
                Console.Write("Any character appears more than two times.");
            else
                Console.Write("No repeated characters");
        }


    }
}
