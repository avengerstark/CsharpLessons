using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ClassArray
{
    class Program
    {
        // Абстрактный класс Array

        // Все массивы являются производными от класса Array.
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array; // привидение к базовому типу

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
        }
    }
}
