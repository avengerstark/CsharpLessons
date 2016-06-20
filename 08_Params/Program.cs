using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Params
{
    class Program
    {
        // Ключевое слово params, позволяет определить параметр метода, принимающий переменное количество  аргументов
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
        }
        static void Main(string[] args)
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            Console.ReadKey();
        }
    }
}
