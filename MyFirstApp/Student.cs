using System;

namespace ConsoleWithDbCrud
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public string? Address { get; set; }
        public DateOnly DOB { get; set; }
        public bool Gender { get; set; }

    }

}
