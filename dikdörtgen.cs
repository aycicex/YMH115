using System;
class HelloWorld {
    static void Main(string[] args)
    {
    int kisa, uzun, alan, cevre;
    
    Console.Write("Kısa Kenar : ");
    kisa = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Uzun Kenar : ");
    uzun = Convert.ToInt32(Console.ReadLine());
    
    alan = kisa * uzun;
    cevre = 2 * (kisa + uzun);
    
    Console.WriteLine("Alan : " + alan);
    Console.WriteLine("Çevre : " + cevre);

    }
}
