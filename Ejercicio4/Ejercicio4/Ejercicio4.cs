using System;

namespace OperacionesVariables
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            // Declarar variable entera N y asignar un valor
            int N = 1;

            // Mostrar valor inicial de N
            Console.WriteLine("Valor inicial de N = " + N);

            // Realizar operaciones
            int incremento = N + 77;
            int decremento = N - 3;
            int duplicar = N * 2;

            // Mostrar resultados
            Console.WriteLine("N + 77 = " + incremento);
            Console.WriteLine("N - 3 = " + decremento);
            Console.WriteLine("N * 2 = " + duplicar);

            Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        }
    }
}