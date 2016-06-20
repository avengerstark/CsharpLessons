using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ковариантность массивов в C#

namespace _06_Covariant
{
    public interface IAnimal
    {
        void Voice();
    }

    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs =  { new Dog(), new Dog(), new Dog() };

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.WriteLine(new string ('-',10));

            IAnimal[] animal = dogs; // Ковариантность

            for (int i = 0; i < dogs.Length; i++)
            {
                animal[i].Voice();
                //animal[i].Jump();
            }

            Console.WriteLine(new string('-',10));

            dogs = (Dog[])animal; // Не является Контрвариантностью.

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.ReadKey();
        }
    }
}
//**********************Масивы в C# ковариантные, но не контравариантные