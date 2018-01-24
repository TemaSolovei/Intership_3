using System;

namespace Intership_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y; // X - координата X, Y - координата Y

            X = checkDouble("Введите координату X: ");
            Y = checkDouble("Введите координату Y: ");

            Console.WriteLine("u = {0:0.000}", checkRegion(X, Y));
        }

        static double checkDouble(string message)
        {
            double result; // result - проверенная переменная
            bool ok; // Проверка ввода

            do
            {
                Console.Write(message);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (!ok) Console.WriteLine("Ошибка ввода, введите вещественное число!");
            } while (!ok);

            return result;
        }

        static double checkRegion(double X, double Y)
        {
            if ((Math.Pow(X, 2) + Math.Pow(Y, 2) <= 1) && (Y >= 0))
            {
                if (!((Math.Pow(X, 2) + Math.Pow(Y, 2) <= 0.09) && (X >= 0) && (Y >= 0)))
                {
                    return Math.Pow(X, 2) - 1;
                } 
            }

            return Math.Sqrt(Math.Abs(X - 1));
        }
    }
}
