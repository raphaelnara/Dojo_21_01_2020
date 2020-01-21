using System;

namespace Desafio1.Partidas.Util
{
    public static class ConsoleUtil
    {
        public static string ObterInput(string mensagem)
        {
            string input;
            do
            {
                Console.WriteLine(mensagem);
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(input));

            return input;
        }
    }
}
