using System;
class Program{

  static void Main(){
    int fNum=10, sNum=20;
    swap(ref fNum, ref sNum);
    System.Console.WriteLine($"{fNum}, {sNum}");
  }

  static void swap(ref int a,ref int b){
    int tNum= a;
    a = b;
    b= tNum;
  }
}
