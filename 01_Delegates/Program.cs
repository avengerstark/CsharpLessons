using System;

//Делегаты

namespace _01_Delegates
{
    //Класс, метод которого будет сообщен с делегатом
    static class MyClass
    {
        public static void Method()
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
            MyDelegate myDelegate = new MyDelegate(MyClass.Method); // Создаем экземпляр делегата (2)

            myDelegate.Invoke(); // Вызываем метод сообщеггый с делегатом (3)

            myDelegate(); // Другой способ вызова метода сообщенного с делегатом (3')


            Console.ReadKey();

        }
    }
}
