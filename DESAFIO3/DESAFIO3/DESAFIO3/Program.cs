using System;

//TODO:Complete os espaços em branco com uma possível solução para o problema.
public class Program
{
    static void Main()
    {
        double chico = 300 *Int32.Parse(Console.ReadLine());
        double bento = 1500 *Int32.Parse(Console.ReadLine());
        double bernardo = 600 *Int32.Parse(Console.ReadLine());
        double marina = 1000 *Int32.Parse(Console.ReadLine());
        double iara = 150 *Int32.Parse(Console.ReadLine());
        double marlene = 225;
        double total = chico + bento + bernardo + marina + iara + marlene;
        Console.WriteLine(total);
    }
}