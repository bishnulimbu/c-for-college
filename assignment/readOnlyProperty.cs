using System;

namespace myProject
{
    public class Person
    {
        public int Data1 { get; private set; }
        public int Calculate
        {
            get { return Data1 * Data1; }
        }

        public Person(int value)
        {
            Data1 = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(10);
            Console.WriteLine(p1.Calculate);
        }
    }
}
