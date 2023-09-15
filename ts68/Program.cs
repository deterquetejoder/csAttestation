//  Напишите программу вычисления функции Аккермана
//   с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

namespace AckermannFunction
{
    class Program
    {
        static int Input(string msg)
    {
        Console.WriteLine(msg);
        int res = Convert.ToInt32(Console.ReadLine());
        return res;
    }
        static int CalculateAckermannFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1; // Base case 1: m = 0
            }
            else if (m > 0 && n == 0)
            {
                return CalculateAckermannFunction(m - 1, 1); // Base case 2: m > 0, n = 0
            }
            else
            {
                return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1)); // Recursive case: m > 0, n > 0
            }
        }

        static void Main(string[] args)
        {
            int m = Input("Enter M: "); // Input m
            int n = Input("Enter n: "); // Input n
            Console.WriteLine($"Akkermann function result for m = {m}, n = {n} is: {CalculateAckermannFunction(m, n)}");
        }
    }
}