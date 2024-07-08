using System;
class Program
{
    static void Main()
    {
        int[] nums = new int[10];
        Console.WriteLine("enter 10 numeber");
        for (int i = 0; i < 10; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        sorting(nums);
        Console.WriteLine();
        foreach (int n in nums)
        {
            Console.Write(n + " ");
        }

    }
    static void sorting(int[] nums)
    {
        Array.Sort(nums);
    }
}


