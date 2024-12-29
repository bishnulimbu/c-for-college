using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int a = 5,
                b = 0;
            Console.WriteLine(a / b);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution complete.");
        }
    }
}
