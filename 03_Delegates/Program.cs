using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Делегаты.

namespace _03_Delegates
{
    //Класс, метод которого будет сообщен с делегатом
    class MyClass // На этот раз класс нестатичный 
    {
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }


    // На 21 - ой строке создаем класс-делегата с именем MyDelegate,
    // метод, который будет сообщен с экземпляром данного класса - делегата,
    // не будет ничего принимать и не будет ничего возвращать.

    public delegate string MyDelegate(string name); // Создаем класс делегата (1)

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method); // Создаем экземпляр делегата и сообщяем с ним метод (2)

            string greeting = myDelegate.Invoke("Magneto"); // Вызываем метод сообщенный с делегатом (3)

            Console.WriteLine(greeting);

            greeting = myDelegate("Tony Stark"); // Другой способ вызова метода сообщенного с делегатом (3')

            Console.WriteLine(greeting);

            Console.ReadKey();
        }
    }
}
