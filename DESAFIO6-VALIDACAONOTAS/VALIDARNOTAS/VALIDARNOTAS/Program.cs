using System;
using System.Globalization;

class Program
{
    
    static void Main()
    {
        //declare suas variaveis corretamente
        double N1, N2;
        int NovoCalculo = 1;
        double media;
        CultureInfo cultura = new CultureInfo("en-US");
       
        //continue a solução ou implemente da sua maneira

        while (NovoCalculo == 1)
        {
           

            
            N1 = double.Parse(Console.ReadLine(), cultura);
            while (0 > N1 || N1 > 10)
            {
                Console.WriteLine("nota invalida");
                N1 = double.Parse(Console.ReadLine(), cultura);
          
            }

            N2 = double.Parse(Console.ReadLine(), cultura);
            while (0 > N2 || N2 > 10)
            {
                Console.WriteLine("nota invalida");
                N2 = double.Parse(Console.ReadLine(), cultura);
            }

            media = (N1 + N2) / 2;

            
            Console.WriteLine($"media = {media.ToString("0.00", cultura)}");


            Console.WriteLine("novo calculo (1-sim 2-nao)");
            NovoCalculo = int.Parse(Console.ReadLine());
            

            while (NovoCalculo < 1 || NovoCalculo > 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                NovoCalculo = int.Parse(Console.ReadLine());
            }

        }
  
    }
}
