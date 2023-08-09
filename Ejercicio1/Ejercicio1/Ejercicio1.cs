using System;

namespace OperacionesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara dos variables numéricas
            int numero1 = 10;
            int numero2 = 5;

            // Realiza las operaciones matemáticas
            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int multiplicacion = numero1 * numero2;
            double division = (double)numero1 / numero2;
            int modulo = numero1 % numero2;

            // Muestra los resultados por consola
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: " + multiplicacion);
            Console.WriteLine("División: " + division);
            Console.WriteLine("Módulo: " + modulo);

            Console.ReadLine(); // Espera a que el usuario presione Enter para salir
        }
    }
}