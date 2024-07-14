using System;
using System.Collections;
enum gender
{
    male, female, trans
}
class Program
{
    static void Main()
    {
        ArrayList al = new ArrayList();
        al.Add(10);
        al.Add(20);
        al.Add(30);
        al.Add(40);
        al.Add(50);
        al.Add("ram");
        al.Add("sam");
        al.Add("hari");
        al.Remove(20);
        for (int i = 0; i < al.Count; i++)
        {
            Console.WriteLine("the index of the arraylist is " + al[i] + " is " + i);
        }
        System.Console.WriteLine("the count of the arraylist is " + al.Count);
        System.Console.WriteLine("the capacity of the arraylist is " + al.Capacity);
    }
}
