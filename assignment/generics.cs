using System;

public class Program
{
    public static void print<T>(T message)
    {
        Console.WriteLine(message);
    }

    public static void Main(string[] args)
    {
        print(111);
        print("hello");
        print(222);
    }
}
