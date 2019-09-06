using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    class Program
    {
        static List<T> Filter<T>(EvenOrOdd<T> filter,List<T> numbers)
        {
            List<T> returnList = new List<T>();
            foreach(T item in numbers)
            {
                if (filter(item))
                    returnList.Add(item);
            }

            return returnList;
        }
        static void PrintList<T>(List<T> numbers)
        {

            foreach (T item in numbers)
            {
                    Console.Write(item + "\n");
            }
                
            Console.Write("\n");
        }
        static void Main()
        {
            List<int> Numbers = new List<int> { 0, 6, 5, 3, 2, 4, 1, 7, 8, 9 };
            FilterClass filter = new FilterClass();
            EvenOrOdd<int> filterEven = filter.IsEven;
            EvenOrOdd<int> filterOdd = filter.IsOdd;
            EvenOrOdd<int> greaterThanFive = filter.IsGreaterthanFive;

            EvenOrOdd<int> anonymous = delegate (int num)
            {
                return num > 2 && num < 5 ? true : false;
            };

            Numbers = Filter(anonymous, Numbers);

            List<Product> products = new List<Product>
            {
                new Product{Name = "dell xps", Id = 1, Price = 40000, Description = "new laptop from dell"},
                new Product{Name = "MotoG3", Id = 2, Price = 5000, Description = "New mobile from Motorola"},
                new Product{Name = "Hpnote", Id = 3, Price = 45000, Description = "Hp laptop"}
            };
            EvenOrOdd<Product> sortProductPrice = (product) => product.Price >= 40000;

            EvenOrOdd<Product> sortPrductName = (product) => product.Name.Contains('M');

            SortProduct sorter = new SortProduct();

            //products.Sort(sorter);

            Comparison<Product> compareLogic = (x, y) => x.Name.CompareTo(y.Name);

            products.Sort(compareLogic);

            PrintList<Product>(products);

            products =  Filter<Product>(sortPrductName, products);

            PrintList<Product>(products);
        }
    }
}
