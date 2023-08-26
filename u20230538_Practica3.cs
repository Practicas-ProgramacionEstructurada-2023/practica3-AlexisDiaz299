using System;
using System.Drawing;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //DECLRACION DE VARIABLES 
            string? Marca_Zapato; 
            string? Color_Zapato; 
            int Cantidad;
            double Precio_Zapato;

            //CAPTURANDO DATOS
            Console.WriteLine("\n------- Capturando Variables -------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos  a comprar:");
            Marca_Zapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese el color del par de zapatos:");
            Color_Zapato = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nIngrese la cantidad de pares de zaptaos a comprar:");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngresar el precio del par de zapatos a comprar:");
            Precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("------- Fin de capturacion de variables -------\n");

            //CAPTURANDO EL TOTAL A PAGAR
            double Total = Cantidad * Precio_Zapato;
            
            //IMPRESION DE VARIABLES
            Console.WriteLine("\n------- Imprimiendo resultados -------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La marca de zapatos a comprar es: " + Marca_Zapato);
            Console.WriteLine("\nEl color de los zapatos a comprar es: " + Color_Zapato);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLa cantidad de pares zapatos a comprar es: " + Cantidad);
            Console.WriteLine("\nEl precio por par de zapatos a comprar es: " + Precio_Zapato);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEl total a pagar es: " + Total);
            Console.ResetColor();
            Console.WriteLine("------- Fin de imprimir resultados -------\n");


        }
    }
}