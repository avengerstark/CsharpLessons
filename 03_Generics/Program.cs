using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Универсальный метод

namespace _03_Generics
{
    class MyClass
    {
        public void Method<T>(T argument)
        {
            T variable = argument;
            Console.WriteLine(variable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Method<string>("Hello world!"); // Явное указание типа string.

            instance.Method("Привет мир!"); // компилятор сам распазнает тип.

            // Delay.

            Console.ReadKey();
        }
    }
}
