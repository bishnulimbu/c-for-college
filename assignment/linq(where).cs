using System;
using System.Collections.Generic;
using System.Linq;

public class Progarm
{
    public static void Main()
    {
        // int[] numbers = { 1, 2, 3, 4, 5 };
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var evenNum = numbers.Where(n => n % 2 == 0);
        foreach (int val in evenNum)
        {
            Console.WriteLine(val);
        }
    }
}
