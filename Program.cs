/*using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length == 0)
            {
                throw new Exception("Nenhum argumento foi passado! Por favor, informe pelo menos um número.");
            }

            Console.WriteLine($"Foram passados {args.Length} argumentos:");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argumento {i + 1}: {args[i]}");
            }

            if (!int.TryParse(args[0], out int numero))
            {
                throw new Exception("O primeiro argumento precisa ser um número inteiro.");
            }

            Console.WriteLine($"O quadrado do primeiro argumento é: {numero * numero}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

    }
}
*/
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
            throw new Exception ("Por favor preencha o campo acima.");
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