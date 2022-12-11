using System;
class HelloWorld {
    static void Main(string[] args)
    {
    
    double gelis, karOran, gidis;
    
    Console.Write("alis fiyatini girin: ");
    gelis = Convert.ToDouble(Console.ReadLine());
   
    Console.Write("Kar Oranını Girin : ");
    karOran = Convert.ToDouble(Console.ReadLine());
    
    gidis = gelis+(gelis * karOran / 100);
    Console.WriteLine("satilmasi gereken fiyat:"+ gidis);

    }
}
