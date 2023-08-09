using System;

namespace OperacionesVariables
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            // Declarar las variables
            int N = 5;
            double A = 4.56;
            char C = 'a';

            // Mostrar el valor de cada variable
            Console.WriteLine("Variable N = " + N);
            Console.WriteLine("Variable A = " + A);
            Console.WriteLine("Variable C = " + C);

            // Realizar operaciones
            double sumaNA = N + A;
            double diferenciaAN = A - N;
            int valorNumericoC = (int)C;

            // Mostrar resultados de las operaciones con formato
            Console.WriteLine(N + " + " + A + " = " + sumaNA);
            Console.WriteLine(A + " - " + N + " = " + diferenciaAN);
            Console.WriteLine("Valor numérico del carácter " + C + " = " + valorNumericoC);

            Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        }
    }
}