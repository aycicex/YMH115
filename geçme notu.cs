using System;
class HelloWorld {
  static void Main() {
   
        double s1, s2;
        double ort;
        Console.WriteLine("Vize notunu giriniz...");
        s1=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Final notunu giriniz...");
        s2=Convert.ToInt16(Console.ReadLine());
        ort = (s1 * 0.4) + (s2 * 0.6);
        if(ort < 50 || s2 < 50)
        {
            Console.WriteLine("Dersten kaldınız...");

        }
        else
        {
            Console.WriteLine("Dersten Geçtiniz...");
        }
  }
}

