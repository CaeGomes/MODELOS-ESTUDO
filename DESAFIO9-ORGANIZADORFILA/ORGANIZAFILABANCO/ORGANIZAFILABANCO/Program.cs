using System;
using System.Collections.Generic;


public class Program
{
    static void Main()
    {
        //Entrada 1 - Qtde de filas
        int limit = int.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++)
        {
            if (i > 1000) return;

            //Entrada 2 - Qtde de senhas entregues p pessoas
            int qtdePessoas = int.Parse(Console.ReadLine());

            //Cria lista
            List<int> lista = new List<int>();

            //Informa senhas de acordo com a qtde da Entrada 2
            string[] line = Console.ReadLine().Split(" ");

            //Verifica as senhas informadas
            foreach(string item in line)
            {
                //Verifica se a qtde de senhas é maior que 1000
                if (lista.Count > 1000) return;

                //Se a qtde de senhas for menor q 1000, insira a senha do Foreach na lista
                lista.Add(int.Parse(item));  
            }

            //Ordena a lista
            lista.Sort((a, b) => b.CompareTo(a));

            int quantidade = qtdePessoas;
            for (int j = 0; j < lista.Count; j++)
            {
                if (int.Parse(line[j]) != lista[j])
                {
                    quantidade--;
                }
            }

            Console.WriteLine(quantidade);
        }
    }
    
}
