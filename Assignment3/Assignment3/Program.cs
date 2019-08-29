using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter vehicle initial speed");
            int speed = int.Parse(Console.ReadLine());
            Vehicle v = new Vehicle(speed);
            try
            {
                while(true)
                {
                    Console.WriteLine("Enter speed");
                    int s = int.Parse(Console.ReadLine());
                    v.IncrementSpeed(s);
                }
            }
            catch(OverSpeedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                int s = v.Speed;
                Console.WriteLine($"Speed : {s}");
            }

        }
    }
}
