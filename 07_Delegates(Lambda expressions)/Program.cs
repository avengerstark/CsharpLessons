using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Лямбда выражения и лябда операторы.

namespace _07_Delegates_Lambda_expressions_
{
    public delegate int MyDelegate(int a);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            myDelegate = delegate(int x) { return x * 2; }; // Лямбда-Метод.

            myDelegate = (x) => { return x * 2; }; // Лямбда-Оператор.

            myDelegate = x => x * 2;   // Лямбда-Выражение.

            int result = myDelegate(4);
            Console.WriteLine(result);

            //Delay.
            Console.ReadKey();
        }
    }
}



