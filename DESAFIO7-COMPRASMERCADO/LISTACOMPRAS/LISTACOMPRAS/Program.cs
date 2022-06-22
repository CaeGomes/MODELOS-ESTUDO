using System;
using System.Collections.Generic;
using System.Linq;

class MinhaClasse
{
    public static void Main(string[] args)
    {
        var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
        // Implemente a solução aqui
        for (int i = 0; i < totalDeCasosDeTeste; i++)
        {
            string[] line = (Console.ReadLine()).Split(" ");

            //Remove itens duplicados
            string[] removeDuplicados = line.Distinct().ToArray();

            string X = line[0];

            //Declaração da lista
            List<string> lista = new List<string>();

            lista.Add(line[0]);

            //Ordena a lista 
            Array.Sort(removeDuplicados);
            //Imprime lista ordenada sem itens duplicados
            Console.WriteLine(string.Join(' ', removeDuplicados));

        }

    }
}