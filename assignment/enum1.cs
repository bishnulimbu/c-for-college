using System;
enum gender
{
    male, female, trans
}
class Program
{
    static void Main()
    {
        foreach (String gen in Enum.GetNames(typeof(gender)))
        {
            Console.WriteLine(gen);
        }
        foreach (int gen in Enum.GetValues(typeof(gender)))
        {
            Console.WriteLine(gen);
        }
        Console.WriteLine(gender.trans);
        Console.WriteLine((int)gender.male);
    }
}
