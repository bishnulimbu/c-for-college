using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number for fibonacci");
        int n = Convert.ToInt32(Console.ReadLine());
        int first = 0, second = 1, next;
        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
            {
                next = i;
            }
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.Write(next + " ");
        }
    }
}


//n number of fibonacci using recursion
//should be 0,1,1,2,
//0,0+1, 1+1
