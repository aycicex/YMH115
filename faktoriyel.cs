using System;
class HelloWorld {
    static void Main() {
    Console.Write("Hesaplanması gereken sayıyı girin: ");
    int s1 = Convert.ToInt32(Console.ReadLine());
    int fact = 1;
    for (int i = 1; i <= s1; i++)
    {
        fact *= i;
    }
    
    Console.WriteLine("Girilen sayının faktoriyeli = " + fact);
  }
}

