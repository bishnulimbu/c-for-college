using System;

public class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        // set { name = value; }
    }

    // public void SetName(string name)
    // {
    //     Name = name;
    // }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        // person.SetName("ram");
        person.Name = "sam";
        Console.WriteLine(person.Name);
    }
}
