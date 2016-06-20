using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Анонимные (лямбда) методы.

namespace _05_Delegates
{
    // Создаем класс делегата.
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод.
            //MyDelegate myDelegate = new MyDelegate( delegate { Console.WriteLine("Hello world!"); });
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); }; // Можно и так

            // Вывоз анонимного метода, сообщенного с делегатом.
            myDelegate();

            // Delay
            Console.ReadKey();

        }
    }
}
