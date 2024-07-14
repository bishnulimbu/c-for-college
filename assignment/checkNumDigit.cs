using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a number.");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(checkDigitSum(n));
    }
    static int checkDigitSum(int n)
    {
        return Math.Abs(n.ToString().Length);
    }
}



//n number of fibonacci using recursion
//should be 0,1,1,2,
//0,0+1, 1+1
