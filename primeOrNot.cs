using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number for checking prime or not");
        // int n = Convert.ToInt32(Console.ReadLine());
        String input = Console.ReadLine();
        int n = 0;
        if (n < 0 || !int.TryParse(input, out n))
        {
            Console.WriteLine("invalid input");
        }
        else if (n == 0 || n == 1)
        {
            Console.WriteLine("1 and 0 are neither prime nor composite");
        }
        else if (checkPrime(n))
        {
            Console.WriteLine("prime");
        }
        else
        {
            Console.WriteLine("its a composite number");
        }
    }
    static bool checkPrime(int n)
    {
        // int divisible = 0;
        // for (int i = 2; i <= n; i++)
        // {
        //     if (n % i == 0)
        //     {
        //         divisible++;
        //     }
        // }
        // if (divisible >= 2)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false; // n is divisible by i, so it is not prime
            }
        }
        return true;

    }
}



//n number of fibonacci using recursion
//should be 0,1,1,2,
//0,0+1, 1+1
