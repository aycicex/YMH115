using System;
class HelloWorld {
    static void Main() {
    double s1,yuzde, result;
        Console.Write("Sayıyı Girin : ");
        s1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Yüzdeyi Girin : ");
        yuzde = Convert.ToDouble(Console.ReadLine());
        result = s1 * yuzde / 100;
        Console.WriteLine("Sayının % {0}' i : {1}",yuzde, result);
  }
}

