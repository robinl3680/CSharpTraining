using System;
using System.Collections.Generic;
namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string");
            string sentence = Console.ReadLine();
            SortedList<string, int> result= WordsCount.CountWords(sentence);
            foreach(KeyValuePair<string,int> item in result)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
