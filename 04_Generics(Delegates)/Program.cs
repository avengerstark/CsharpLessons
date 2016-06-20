using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Универсальный делегат
//git 
namespace _04_Generics_Delegates_
{
    // На 16-й строке создаем класс-делегат с именем MyDelegate, параметризированный двумя указателями
    // Места Заполнения Типов T и R, метод который дудет сообщен с экземпляром данного класса-делегата,
    // будет принимать один аргумент, типа Указателя Места Заполнения Типа - T и возвращать значение
    // типа Указателя Места Заполнения Типом - R.

    delegate R MyDelegate<T, R>(T t);
    class Program
    {
        public static int Add(int i)
        {
            return ++i;
        }

        public static string Concatenation(string s)
        {
            return "Hello " + s + "!";
        }
        static void Main(string[] args)
        {
            MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
            int i = myDelegate1.Invoke(1);
            Console.WriteLine(i);

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Concatenation);
            string str = myDelegate2.Invoke("Magneto");
            Console.WriteLine(str);

            // Delay.
            Console.ReadKey();
        }
    }
}
