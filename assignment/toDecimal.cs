using System;
class Program
{
    static void Main()
    {
        toDecimal(10);
    }
    static void toDecimal(int num)
    {
        int temp = 0;
        while (num > 0)
        {
            temp = num % 1;
            num = num / 10;
            temp += temp * 2;
        }
    }
}
//from binaray 101011 to decimal. 
