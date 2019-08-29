using System;
using System.Collections.Generic;
namespace Asignment1
{
    class Program
    {
        static void Main()
        {
            
            CompositeFinder composite = new CompositeFinder();
            Console.WriteLine("Enter the string");
            string sentence = Console.ReadLine();
            List<string> result = CompositeFinder.FindCompositeWordds(sentence);
            foreach(string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
