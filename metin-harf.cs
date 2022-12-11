using System;
public class HelloWorld
{
    static void Main(string[] args)
    {  
    Console.WriteLine("Metin Girin:");
    string metin = Console.ReadLine();
 
    for (int i = 0; i < metin.Length; i++)
    {
        Console.WriteLine(metin[i]);
    }
    }
}
