using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Универсальные шаблоны.

namespace _01_Generics
{

    // На 14-й строке создаем класс с именем MyClass, параметризированный Указатель Места Заполнения Типом - Т

    class MyClass<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса MyClass и в качестве параметра типа передаем тип int.
            MyClass<int> instance1 = new MyClass<int>();
            instance1.Method();

            // Создаем экземпляр класса MyClass  ив качестве параметро типа передаем тип long.
            MyClass<long> instance2 = new MyClass<long>();
            instance2.Method();

            // Создаем экземпляр класса MyClass  ив качестве параметро типа передаем тип string.
            MyClass<string> instance3 = new MyClass<string>();
            instance3.field = "Megneto";
            instance3.Method();

            //Delay.
            Console.ReadLine();
        }
    }
}
