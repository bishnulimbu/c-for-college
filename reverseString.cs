using System;
class Program{
  static void Main(){
    string str= "bishnu";
    reverse(ref str);
    Console.WriteLine(str);

  }
  static void reverse(ref string one){
    char[] charArray = one.ToCharArray();
    Array.Reverse(charArray);
    one = new String(charArray);
  }
}
//string b = new StringBuilder(" ");
// for(int i= word.length - 1; i >= 0;i--){
//  b.Append(word[i]);
// }
// return b.ToString();
//three types of reverse string technique: 1. using string builder, 2. uing character and 3. using Array.Reverse(array) method.
