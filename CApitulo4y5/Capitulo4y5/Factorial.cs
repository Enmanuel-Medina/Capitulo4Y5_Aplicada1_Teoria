using System;
using System.Collections.Generic;
using System.Text;

namespace CApitulo4y5.Capitulo4y5
{
    class Factorial
    {
        public int num { get; set; }

        public Factorial() { }
        public int factorial(int num)
        {
            if (num == 0 || num == 1)
                return num;
            return num * factorial(num - 1);
        }

        public void calcularFactorial()
        {
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("El factorial de " + num + " es: " + factorial(num));
        }
    }
}
