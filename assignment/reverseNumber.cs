using System;
class Program
{
    static void Main()
    {
        int num = 123;
        System.Console.WriteLine(reverse(ref num));
    }
    static int reverse(ref int num)
    {
        int temp = 0, rem = 0;
        while (num > 0)
        {
            rem = num % 10;
            num = num / 10;
            temp = rem + temp * 10;
        }
        return temp;
    }

}
