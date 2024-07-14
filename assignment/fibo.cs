
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number for fibonacci");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine(fibo(i) + " ");

        }
        fibo(n);
    }
    static int fibo(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return fibo(n - 1) + fibo(n - 2);
    }
}


//n number of fibonacci using recursion
