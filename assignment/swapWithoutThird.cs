using System;
class Program{
  static void Main(){
    int first= 100, second = 200;
    swap(ref first, ref second);
    Console.WriteLine("first: " + first + " second: " + second );

  }
  static void swap(ref int a, ref int b){
    int sum = a+b;
    a= sum-a;
    b= sum-b;
  }
}



