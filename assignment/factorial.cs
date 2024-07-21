using System;
class Program
{
    static void Main()
    {
        int num = 0;
        factorial(10);
    }
    static void factorial(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
//factorial of a number.
