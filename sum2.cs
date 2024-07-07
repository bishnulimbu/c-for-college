    // Console.Write("enter the first number:");
    // int fNum = Convert.ToInt32(Console.ReadLine());
    // Console.Write("enter the second number:");
    // int sNum = Convert.ToInt32(Console.ReadLine());
    // int sum = fNum + sNum;
    // Console.WriteLine("sum" +" : "+ sum);
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers separated by a space:");
        
        // Read the input line
        string input = Console.ReadLine();
        
        // Split the input line by spaces
        string[] inputs = input.Split(' ');
        
        // Parse the individual inputs to the desired type, e.g., int
        int firstNumber = int.Parse(inputs[0]);
        int secondNumber = int.Parse(inputs[1]);
        
        // Output the values to verify
        Console.WriteLine("First number: " + firstNumber);
        Console.WriteLine("Second number: " + secondNumber);

        int sum = firstNumber + secondNumber;
        Console.WriteLine("Sum:" + sum);
    }
}
