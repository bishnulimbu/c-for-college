using System;
using System.Collections.Generic;
enum gender
{
    male, female, trans
}
class Program
{
    static void Main()
    {
        List<int> nums = new List<int>(){
      1,2,3,4,5
    };
        foreach (int i in nums)
        {
            System.Console.Write(i + " ");
        }
    }

}
