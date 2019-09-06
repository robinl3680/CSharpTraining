using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateModel
{
    delegate int MyDelegate(int num1, int num2);
    
    class Program
    {
        static void Main()
        {
            MyDelegate delegateadd = ( num1,  num2) => num1 + num2;
            
            MyDelegate delegatemultiply = ( num1,  num2) => num1 * num2;
           

            Console.WriteLine(delegateadd(10, 20));
            Console.WriteLine(delegatemultiply(10, 20));

        }
    }
}
