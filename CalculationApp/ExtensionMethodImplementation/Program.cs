using System;
using System.Collections.Generic;
using System.Linq;
namespace ExtensionMethodImplementation
{
    class Program
    {
        static List<T> Filter<T>(List<T> input, Predicate<T> predicate)
        {
            List<T> output = new List<T>();
            input.ForEach(num =>
            {
                if (predicate(num))
                    output.Add(num);
            });
            return output;
        }
        static void Main()
        {
            List<int> numbers = new List<int>
            {
                1,2,5,6,8,9,0,7,4,3
            };

            Func<int, bool> even = (num) => num % 2 == 0;
            IEnumerable<int> number = numbers.Where(even);
            List<int> numb = number.ToList<int>();
            Action<int> printLogic = item => Console.Write(item + "\t");
            numb.ForEach(printLogic);



            Predicate<int> evenLogic = (num) => num % 2 == 0;
            List<int> result = Filter<int>(numbers, evenLogic);
            
            //result.ForEach(printLogic);

        }
    }
}
