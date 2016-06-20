using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Анонимные методы с параметрами 

namespace _06_Delegates_Anon_mmethod_with_parameters_
{
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum = 0;

            MyDelegate myDelegate = delegate(int a, int b) { return a + b; };

            sum = myDelegate(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}",summand1, summand2, sum);

            // Delay
            Console.ReadKey();
        }
    }
}
