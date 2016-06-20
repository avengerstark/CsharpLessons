using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ArrayMultiDim
{
    class Program
    {
        //********************Трехмерные массивы************
        static void Main(string[] args)
        {
            int[, ,] threeDim = {
                                     { { 1, 2},{ 3, 4}, { 67, 67}},
                                     { { 5,6}, { 7, 8}, { 43, 34}},
                                     { { 5,6}, { 7, 8}, { 43, 34}}
                                 };

            //Получаем количество подмассивов в Массиве  - GetLength(0)

            for (int i = 0; i < threeDim.GetLength(0); i++)
            {
                //Получаем количесво элементов в подмассиве - GetLength(1)
                for (int j = 0; j < threeDim.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDim.GetLength(2); k++)
                    {
                        Console.Write(threeDim[i,j,k]+", ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Общий размер массива: "+threeDim.Length);
            Console.WriteLine("GetLength(0): " + threeDim.GetLength(0));
            Console.WriteLine("GetLength(1): " + threeDim.GetLength(1));
            Console.WriteLine("GetLength(2): " + threeDim.GetLength(2));

            Console.ReadLine();
        }
    }
}
