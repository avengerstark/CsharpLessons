﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ковариантность обобщений.

namespace _05_Generics_Covariance_
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<out T>
    {
        T Figure { get; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;

        public Container(T figure)
        {
            this.figure = figure;
        }

        public T Figure
        {
            get { return figure; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            IContainer<Shape> container = new Container<Circle>(circle); // Неявное привидение типа.

            Console.WriteLine(container.Figure.ToString());

            //Delay.
            Console.ReadLine();
        }
    }
}