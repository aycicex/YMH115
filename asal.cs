using System;
public class HelloWorld
{
    static void Main(string[] args)
    {
    Console.WriteLine("Sayı Giriniz.:");
    int sayi2=Convert.ToInt16(Console.ReadLine());
    int kontrol = 0;
    int sayac = 0;
    for (int i = 2; i <= sayi2; i++)
    {
        kontrol = 0;
           
        for (int j = 2; j <= i/2; j++)
        {
            if(i%j==0)
            {
                kontrol++;
                break;
            }
        }
        if (kontrol == 0)
        {
            sayac++;
            Console.Write(i+"-");
        }
                
    }
    Console.WriteLine();
    Console.WriteLine("--- {0}  adet asal sayı bulundu.", sayac);
    }
}
