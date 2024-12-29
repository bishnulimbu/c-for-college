// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//constructior overloading means that constructor having different parameters.

using System;

public class Person
{
    public Person()
    {
        Console.WriteLine("person One");
    }

    public Person(string name, int age)
    {
        Console.WriteLine($"Name:{name}");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating an object using the default constructor
        Person obj1 = new Person();

        // Creating an object using the parameterized constructor
        Person obj2 = new Person("John", 30);
    }
}
