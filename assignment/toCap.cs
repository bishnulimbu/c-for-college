using System;
class Program{
  static void Main(){
    string str= "bishnu";
    cap(ref str);
    Console.WriteLine(str);

  }
  static void cap(ref string one){
    one =one.ToUpper();
  }
}

