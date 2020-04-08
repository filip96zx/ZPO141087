using System;
using System.Collections.Generic;

namespace D3
{
    class Program
    {
        public abstract class Figura
        {
            protected double a, b, c;

            public abstract double ObliczPole();

        }

        public class Kwadrat : Figura
        {
            public Kwadrat(int a)
            {
                this.a = a;
            }

            public override double ObliczPole()
            {
                return a * a;
            }
        }

        public class Trojkat : Figura
        {
            public Trojkat(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public override double ObliczPole()
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            lista.Add(new Kwadrat(1));
            lista.Add(new Kwadrat(2));
            lista.Add(new Kwadrat(3));
            lista.Add(new Trojkat(1, 3, 3));
            lista.Add(new Trojkat(3, 3, 1));
            lista.Add(new Trojkat(4, 5, 2));
            lista.Add(new Trojkat(2, 2, 2));

            foreach (Figura obj in lista)
            {
                Console.WriteLine("Pole figury: " + obj.ObliczPole());
            }

            Console.ReadLine();
        }
    }
}
