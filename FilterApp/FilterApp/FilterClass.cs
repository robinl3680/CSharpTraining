using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    delegate bool EvenOrOdd<in T>(T number);

    public class FilterClass
    {
        public FilterClass()
        { }
        public bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
        public bool IsOdd(int number)
        {
            if (number % 2 == 0)
                return false;
            else
                return true;
        }
        public bool IsGreaterthanFive(int number)
        {
            if (number > 5)
                return true;
            else
                return false;
        }
    }
}
