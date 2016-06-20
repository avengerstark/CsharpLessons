using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates
{

    //Класс, метод которого будет сообщен с делегатом
    class MyClass // На этот раз класс нестатичный 
    {
        public void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом");
        }
    }


    // На 21 - ой строке создаем класс-делегата с именем MyDelegate,
    // метод, который будет сообщен с экземпляром данного класса - делегата,
    // не будет ничего принимать и не будет ничего возвращать.

    public delegate void MyDelegate(); // Создаем класс делегата (1)

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass(); 

            MyDelegate myDelegate = new MyDelegate(instance.Method); // Создаем экземпляр делегата (2)

            myDelegate.Invoke(); // Вызываем метод сообщеггый с делегатом (3)

            myDelegate(); // Другой способ вызова метода сообщенного с делегатом (3')


            Console.ReadKey();
        }
    }
}
