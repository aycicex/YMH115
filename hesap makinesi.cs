using System;
class HelloWorld {
  static void Main() {
    
    double sayi1, sayi2, toplam,fark,carpim,bolum;
    Console.Write("ilk sayiyi girin: ");
    sayi1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("ikinci sayıyı giriniz: ");
    sayi2 = Convert.ToDouble(Console.ReadLine());
    
    toplam = sayi1 + sayi2;
    fark = sayi1 - sayi2;
    carpim = sayi1 * sayi2;
    bolum = sayi1 / sayi2;
    
    Console.WriteLine(sayi1 +" ve " + sayi2 + " Sayısının Toplamı : " + toplam);
    Console.WriteLine(sayi1 +" ve " + sayi2 + " Sayısının Farkı : " + fark);
    Console.WriteLine(sayi1 +" ve " + sayi2 + " Sayısının carpimi : " + carpim);
    Console.WriteLine(sayi1 +" ve " + sayi2 + " Sayısının bolumu : " + bolum);
  }
}

