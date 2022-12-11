using System;
class HelloWorld {
    
    static void Main(string[] args)
    {
    
    int sayi;
    int sayi2;
    
    Console.Write("Sayıyı Girin : ");
    sayi = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Bölünecek sayıyı girin: ");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    
        if(sayi%sayi2==0)
        {
        Console.WriteLine("Sayıniz, istediğiniz sayıya bölünüyor");
        }
        
        else
        {
        Console.WriteLine("Sayıniz, istediğiniz sayıya bölünmüyor");
        }

    }
}
