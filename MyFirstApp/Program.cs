using System;

namespace ConsoleWithDbCrud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 1;
            s.name = "Bishanu";
            s.DOB = DateOnly.Parse("1994-01-01");
            DataAccess Da = new DataAccess();


        }
    }
}
