//Calcular el área de un rectángulo (base*altura)
using System;

namespace area_rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int _base = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            int altura = int.Parse(Console.ReadLine());

            int area = altura * _base;
            Console.WriteLine($"El area del rectangulo es: {area}");

            Console.ReadKey();
        }
    }
}
