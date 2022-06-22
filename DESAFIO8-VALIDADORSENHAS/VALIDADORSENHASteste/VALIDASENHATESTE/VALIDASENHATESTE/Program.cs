using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Windows.Input;

using System.Text.RegularExpressions;


class Program
{
    public static void Main()
    {

        // Implemente a solução aqui

        string senha = Console.ReadLine();
        Regex numeros = new Regex("[0-9]");
        Regex mi = new Regex("[a-z]");
        Regex r = new Regex("^[a-zA-Z0-9]+$");
        Regex ma = new Regex("[A-Z]");



        while (!string.IsNullOrEmpty(senha))
        {


            //try
            

                //senha = Console.ReadLine();

                if (senha.Length < 6 || senha.Length > 32)
                {
                    Console.WriteLine("Senha invalida.");

                }
                else if (!numeros.IsMatch(senha))
                {
                    Console.WriteLine("Senha invalida.");

                }
                else if (!mi.IsMatch(senha))
                {
                    Console.WriteLine("Senha invalida.");

                }
                else if (!ma.IsMatch(senha))
                {
                    Console.WriteLine("Senha invalida.");

                }
                else if (senha == null)
                {
                    Console.WriteLine("Senha invalida.");

                }
                else if (r.IsMatch(senha))
                {
                    Console.WriteLine("Senha valida.");

                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }

            //while (Console.ReadKey().Key != ConsoleKey.Enter);
            //{

            //}

            //catch

            senha = Console.ReadLine();

            //return;
        }
        //while (Console.ReadKey().Key != ConsoleKey.Enter || true);
        //while (senha != "" || true) ;


    }
}
