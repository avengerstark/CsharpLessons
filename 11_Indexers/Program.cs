using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Индексаторы (переопределение)

namespace _11_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            BaseClass instance1 = instance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }

            Console.ReadKey();
        }
    }
}
