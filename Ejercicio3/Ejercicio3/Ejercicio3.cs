using System;

namespace OperacionesVariables
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            // Declarar variables enteras
            int X = 10;
            int Y = 5;

            // Declarar variables de tipo double
            double N = 7.5;
            double M = 3.0;

            // Mostrar el valor de cada variable
            Console.WriteLine("Variable X = " + X);
            Console.WriteLine("Variable Y = " + Y);
            Console.WriteLine("Variable N = " + N);
            Console.WriteLine("Variable M = " + M);

            // Realizar operaciones con enteras
            int sumaXY = X + Y;
            int diferenciaXY = X - Y;
            int productoXY = X * Y;
            double cocienteXY = (double)X / Y;
            int restoXY = X % Y;

            // Realizar operaciones con doubles
            double sumaNM = N + M;
            double diferenciaNM = N - M;
            double productoNM = N * M;
            double cocienteNM = N / M;
            double restoNM = N % M;

            // Realizar otras operaciones
            int sumaXN = X + (int)N;
            double cocienteYM = Y / M;
            double restoYM = Y % M;
            int dobleX = X * 2;
            int dobleY = Y * 2;
            double dobleN = N * 2;
            double dobleM = M * 2;

            // Realizar operaciones finales
            int sumaTotal = X + Y + (int)N + (int)M;
            double productoTotal = X * Y * N * M;

            // Mostrar resultados
            Console.WriteLine("X + Y = " + sumaXY);
            Console.WriteLine("X - Y = " + diferenciaXY);
            Console.WriteLine("X * Y = " + productoXY);
            Console.WriteLine("X / Y = " + cocienteXY);
            Console.WriteLine("X % Y = " + restoXY);

            Console.WriteLine("N + M = " + sumaNM);
            Console.WriteLine("N - M = " + diferenciaNM);
            Console.WriteLine("N * M = " + productoNM);
            Console.WriteLine("N / M = " + cocienteNM);
            Console.WriteLine("N % M = " + restoNM);

            Console.WriteLine("X + N = " + sumaXN);
            Console.WriteLine("Y / M = " + cocienteYM);
            Console.WriteLine("Y % M = " + restoYM);

            Console.WriteLine("Doble de X: " + dobleX);
            Console.WriteLine("Doble de Y: " + dobleY);
            Console.WriteLine("Doble de N: " + dobleN);
            Console.WriteLine("Doble de M: " + dobleM);

            Console.WriteLine("Suma total de variables: " + sumaTotal);
            Console.WriteLine("Producto total de variables: " + productoTotal);

            Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        }
    }
}
