using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStringUsingLength
{
    class Program
    {
        static void SortStrings(ref List<string> strings)
        {
            StringSort sorter = new StringSort();
            strings.Sort(sorter);
        }
        static void PrintList(List<string> strings)
        {
            foreach (string items in strings)
                Console.WriteLine(items);
        }
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            while(true)
            {
                Console.WriteLine("Enter the string");
                string s1 = Console.ReadLine();
                strings.Add(s1);
                Console.WriteLine("Want to break ? y : yes");
                string y = Console.ReadLine();
                if (y == "y")
                    break;
            }
            SortStrings(ref strings);
            PrintList(strings);
            
            

        }
    }
}
