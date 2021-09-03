using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string nombre;
            int edad;
            double altura, peso, imc, tmbF, tmbM;
            bool F = true;
            bool M = true;
            Console.WriteLine("Cuántas personas desea calcular?: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cant; i++)
            {
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese su altura en metros: ");
                altura = double.Parse(Console.ReadLine().Replace(".", ","));
                Console.Write("Ingrese su peso en kg: ");
                peso = double.Parse(Console.ReadLine());
                Console.Write("Ingrese su genero: ");
                Console.ReadLine();
                //Fórmula para calcular IMC
                imc = peso / altura / altura;
                if (F)
                { 
                    //Fórmula para calcular tasa metabólica basal TMB. Ecuación Harris-benedict.
                    tmbF = 655 + (9.6 * peso) + (1.85 * altura) - (4.7 * edad);
                    Console.WriteLine(nombre + " su IMC es de: " + imc.ToString("N1") + " y su tasa metabolica basal es de: " + tmbF + "\n");
                }
                else if (M)
                {
                    tmbM = 66.5 + (13.8 * peso) +(5 * altura) -(6.8 * edad);
                    Console.WriteLine(nombre + " su IMC es de: " + imc.ToString("N1") + " y su tasa metabolica basal es de: " + tmbM + "\n");
                }
            }
        }
    }
}
