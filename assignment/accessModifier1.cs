class Program
{
    static void Main()
    {
        Person p = new Person();
        // p.name = "Bishanu";
        // p.age = "25";
        // System.Console.WriteLine(p.name + " is of age " + p.age);
        // p.setName("Roshain");
        // System.Console.WriteLine(p.getName() + " is of age 25ys");
        p.Name = "ramuDesh";
        System.Console.WriteLine(p.Name + " is of age 25ys");


    }
    public class Person()
    {
        public string name;
        public string age;
        // public string getName()
        // {
        //     return name;
        // }
        // public void setName(string n)
        // {
        //     name = n;
        // }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
