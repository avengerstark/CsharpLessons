using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TwoDimensional
{
    class Program
    {
       //*************Двумерные массивы****************
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[3,3];

            // Заполняем массив случайными значениями
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }

            //Выводим массив 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                
                    Console.Write("{0} ",array[i,j]);
                }
                Console.Write("\n");
        
            }

            Console.ReadLine();
    
        }
    }
}
