using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CalculationLibrary;
using ExtensionLibrary;
namespace CalculationUser
{
    class Program
    {
        static void Main()
        {
            ICalculation calc = new Calculation();

            WriteLine(calc.Add(10, 20));
            WriteLine(calc.Subtract(20, 5));
            string name = "Robin";
            WriteLine(name.SayHi());
        }
    }
}
