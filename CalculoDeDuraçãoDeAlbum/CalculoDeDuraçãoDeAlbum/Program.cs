using System;

namespace CalculoDuracaoAlbumMusica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo o número de faixas do álbum
            Console.Write("Digite o número de faixas do álbum: ");
            int numeroDeFaixas = int.Parse(Console.ReadLine());

            // Inicializando variável para armazenar a duração total do álbum
            TimeSpan duracaoTotal = TimeSpan.Zero;

            // Iterando sobre cada faixa do álbum
            for (int i = 1; i <= numeroDeFaixas; i++)
            {
                Console.WriteLine($"\nDigite a duração da faixa {i} (hh:mm:ss): ");
                string duracaoFaixaStr = Console.ReadLine();

                // Convertendo a entrada do usuário para TimeSpan
                TimeSpan duracaoFaixa;
                if (TimeSpan.TryParse(duracaoFaixaStr, out duracaoFaixa))
                {
                    // Adicionando a duração da faixa à duração total do álbum
                    duracaoTotal = duracaoTotal.Add(duracaoFaixa);
                }
                else
                {
                    Console.WriteLine("Formato inválido. Por favor, use o formato hh:mm:ss.");
                    i--; // Decrementando o índice para repetir a faixa inválida
                }
            }

            // Exibindo a duração total do álbum
            Console.WriteLine($"\nA duração total do álbum é: {duracaoTotal}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
