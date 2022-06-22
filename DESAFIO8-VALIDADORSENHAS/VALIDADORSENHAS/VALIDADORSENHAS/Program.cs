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


            senha = Console.ReadLine();

        }
        
    }
}
