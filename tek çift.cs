using System;
class HelloWorld {
    static void Main(string[] args){
    
    int tekAdet=0, ciftAdet=0;
    int[] sayilar=new int[11];
    int sayi1;
    
    for(int i = 1; i <= 10; i++)
    {
    sayi1=Convert.ToInt16(Console.ReadLine());
    sayilar[i] = sayi1;
        
        if(sayi1%2==0)
        {
            ciftAdet++;
        }
        else
        {
            tekAdet++;
        }
    }
    Console.WriteLine("Çift Sayı Adeti : {0}", ciftAdet);
    Console.WriteLine("Tek Sayı Adeti : {0}",tekAdet);
    }
 
}
