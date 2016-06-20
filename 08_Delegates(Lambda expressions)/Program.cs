using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Лямбда выражения и лямбда операторы.

namespace _08_Delegates_Lambda_expressions_
{
    public delegate void MyDelegates();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegates myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); }; // Лямбда-Метод

            myDelegate += () => { Console.WriteLine("Hello 2"); };// Лямбда-Оператор

            myDelegate += () => Console.WriteLine("Hello 3"); // Лямбда-Выражение

            myDelegate.Invoke();

            //Delay
            Console.ReadKey();
        }
    }
}
