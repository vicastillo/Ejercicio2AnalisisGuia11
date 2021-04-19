using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2AnalisisGuia11
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa que ordena valores ingresados.";

            Double n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8 = 0, n9 = 0, n10 = 0;

            List<Double> Lista = new List<Double>();
            Console.WriteLine("Ingrese el primer valor:");
            n1 = Double.Parse(Console.ReadLine());
            Lista.Add(n1);

            Console.WriteLine("Ingrese el segundo valor:");
            n2 = Double.Parse(Console.ReadLine());
            Lista.Add(n2);

            Console.WriteLine("Ingrese el tercer valor:");
            n3 = Double.Parse(Console.ReadLine());
            Lista.Add(n3);

            Console.WriteLine("Ingrese el cuarto valor:");
            n4 = Double.Parse(Console.ReadLine());
            Lista.Add(n4);

            Console.WriteLine("Ingrese el quinto valor:");
            n5 = Double.Parse(Console.ReadLine());
            Lista.Add(n5);

            Console.WriteLine("Ingrese el sexto valor:");
            n6 = Double.Parse(Console.ReadLine());
            Lista.Add(n6);

            Console.WriteLine("Ingrese el séptimo valor:");
            n7 = Double.Parse(Console.ReadLine());
            Lista.Add(n7);

            Console.WriteLine("Ingrese el octavo valor:");
            n8 = Double.Parse(Console.ReadLine());
            Lista.Add(n8);

            Console.WriteLine("Ingrese el noveno valor:");
            n9 = Double.Parse(Console.ReadLine());
            Lista.Add(n9);

            Console.WriteLine("Ingrese el decimo valor:");
            n10 = Double.Parse(Console.ReadLine());
            Lista.Add(n10);

            Console.WriteLine();

            Console.WriteLine("Los valores ordenados de mayor a menor son:" );

            Double[] A = Lista.ToArray();
            Array.Sort(A);
            foreach (Double value in A)
            {
            Console.Write(value);
            Console.WriteLine();
            }

            Console.ReadLine();

            }
            catch (Exception error)
            {
            Console.WriteLine("Error: " + error.Message);
            }

            Console.ReadKey();
        }
    }
}
