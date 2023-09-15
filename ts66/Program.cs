using System;

class Program {
    static int Sum(int m, int n)
    {
        if (m == n)
            return n;
        else
            return m + Sum(m + 1, n);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter M and N:");
        string input = Console.ReadLine();
        int m = Convert.ToInt32(input.Split(' ')[0]);
        int n = Convert.ToInt32(input.Split(' ')[1]);
        Console.WriteLine($"The sum of natural numbers from {m} to {n} is {Sum(m, n)}.");
    }
}