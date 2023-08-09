using System;

namespace OperacionesVariables
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            // Declarar y asignar valores iniciales a las variables enteras A, B, C y D
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;

            // Mostrar valores iniciales
            Console.WriteLine("Valores iniciales:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.WriteLine("D = " + D);

            // Realizar intercambio de valores
            int temp = B;
            B = C;
            C = A;
            A = D;
            D = temp;

            // Mostrar valores después del intercambio
            Console.WriteLine("\nValores después del intercambio:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.WriteLine("D = " + D);

            Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        }
    }
}
