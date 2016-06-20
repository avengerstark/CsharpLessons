using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Arrays
{
    class Program
    {
        //**************Одномерные массивы*******
        static void Main(string[] args)
        {
            // Массив можно инициализировать разными способами.
            int[] array = { 1, 2, 3, 4, 5 };
            array = new int[5];
            array = new int[5] { 1, 2, 3, 4, 5 };
            array = new int[] { 1, 2, 3, 4, 5 };

            //Вывод значений элементов массива.

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
