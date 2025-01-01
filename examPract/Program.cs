using System;

class AgeException:Exception{
    public AgeException(string message){
    :base(message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int age = 11;
            if (age <= 18)
                throw new Exception("age is not valid.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
