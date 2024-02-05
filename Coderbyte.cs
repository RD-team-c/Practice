using System;

class MainClass {

  public static int FirstFactorial(int num) {

    // code goes here  
    for(int i = num; i>0 ; i--){
      i*=(i-1);
      num=i;
    }

    return num;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(FirstFactorial(Console.ReadLine()));
  } 

}