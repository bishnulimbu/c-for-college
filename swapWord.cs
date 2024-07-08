using System;
class Program
{
    static void Main()
    {
        string str1 = "Toggle Case";
        string str2 = "New Word";
        Console.WriteLine(str1 + " " + str2);
        swapString(str1, str2, out str1, out str2);
        Console.WriteLine(str1 + " " + str2);

    }
    static void swapString(string str1, string str2, out string swapped1, out string swapped2)
    {
        string cat = str1 + str2;
        int lengthDiff = str1.Length - str2.Length;
        swapped1 = cat.Substring(0, lengthDiff);
        swapped2 = cat.Substring(lengthDiff);
    }
}
