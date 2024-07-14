using System;
class Program
{
    static void Main()
    {
        string str = "Toggle Case";
        string swapped = swapp(str);
        Console.WriteLine(swapped);

    }
    static string swapp(string Word)
    {
        char[] charArray = new char[Word.Length];
        for (int i = 0; i < Word.Length; i++)
        {
            char c = Word[i];
            if (char.IsUpper(c))
            {
                charArray[i] = char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                charArray[i] = char.ToUpper(c);
            }
            else
            {
                charArray[i] = charArray[i];
            }
        }
        return new String(charArray);
    }
}
