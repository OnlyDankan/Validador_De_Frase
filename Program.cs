using System;
using System.IO;

class Program
{
   static void Main(string[] args)
    {


        Console.Write("Digite sua frase: ");
        string frase = Console.ReadLine() ?? "";
        frase = frase.Trim();

        if (frase.Length == 0)
        {
            throw new Exception ("Por favor preencha o campo");
        }
         
            Char valorAtual = frase[0];

            Console.WriteLine($"A sua frase tem: {frase.Length} de letras");

        bool erro = false;    
        try
        {
             if (frase.Length >= 9)
            {
            throw new Exception ("A frase é muito grande. Tente novamente.");
            }
        }
        catch (Exception ex)
        {
            erro = true;
            Console.WriteLine($"Erro: {ex.Message}");
        }
        if (!erro)
        {
            Console.WriteLine("A sua frase foi aceita.");

            using StreamWriter escritor = new StreamWriter("frase.txt", true);
            escritor.WriteLine(frase);

            escritor.WriteLine("Salvo em: " + DateTime.Now);

            Console.WriteLine($"A sua nova frase é: {frase}");
        }

    }
}