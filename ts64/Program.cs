// Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.     

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = Input("Enter a number: ");
        RecursivePrint(N);
    }

    static int Input(string msg)
    {
        Console.WriteLine(msg);
        int res = Convert.ToInt32(Console.ReadLine());
        return res;
    }

    static void RecursivePrint(int number)
    {
        if (number > 1)
        {
            Console.WriteLine(number);
            RecursivePrint(number - 1);
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}