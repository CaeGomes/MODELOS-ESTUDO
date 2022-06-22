using System;

public class Program
{
    static void Main()
    {
        int limit = int.Parse(Console.ReadLine());

        for (int i = 0; i < limit; i++)
        {
            string[] entrada = Console.ReadLine().Split(" ");
            //int entrada1 = int.Parse(entrada[0]);

            //Lista
            List<int> lista = new List<int>();

            lista.Add(int.Parse(entrada[0]));

            Array.Sort(entrada);
            Array.Reverse(entrada);

            Console.WriteLine(string.Join(" ", entrada));

            lista.Sort((a, b) => b.CompareTo(a));


            //foreach (var item in entrada)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
