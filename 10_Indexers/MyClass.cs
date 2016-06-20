using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Indexers
{
    class MyClass
    {
        private string[] array = new string [5];

        // Индексатор.
        public string this[int index]
        {
            get // Аксессор
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива";
            }

            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределы массива");
            }
        }
    }
}
