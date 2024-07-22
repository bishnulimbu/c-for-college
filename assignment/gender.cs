using System;
class Program
{
    static void Main()
    {
        Person p = new Person();
        System.Console.WriteLine("enter your gender(male/female)");
        string text = Console.ReadLine();
        p.strong = text;
        System.Console.WriteLine(p.strong);

    }
    public class Person
    {
        public string gender;
        public string strong
        {
            get
            {
                return gender;
            }
            set
            {
                if (value.Equals("male") || value.Equals("m"))
                {
                    gender = "---> you are strong";
                }
                else if (value.Equals("female") || value.Equals("f"))
                {
                    gender = "-->  women are weak";
                }
                else
                {
                    gender = "enter male or female(no place for third ones.";
                }
            }
        }

    }
}
// public string Name(get; set;);sort hand 
