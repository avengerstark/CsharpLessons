using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delegates
{
    delegate Delegate2 Delegate1(); // 1
    delegate void Delegate2(); // 2

    class Program
    {
        public static Delegate2 Method1()  // 1
        {
            return new Delegate2(Method2);
        }

        public static void Method2()  // 2
        {
            Console.WriteLine("Hello mad world!");
        }
        static void Main(string[] args)
        {
            Delegate1 delegate1 = new Delegate1(Method1);

            Delegate2 delegate2 = delegate1();

            delegate2();

            // Delay
            Console.ReadKey();
        }
    }
}
