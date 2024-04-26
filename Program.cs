using TrabalhoPratico.Models;
namespace TrabalhoPratico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - A soma de dois vetores");
                Console.WriteLine("2 - A multiplicação de um escalar por um vetor");
                Console.WriteLine("3 - O módulo de um vetor");
                Console.WriteLine("4 - Dados dois pontos A e B, determinar o vetor AB");
                Console.WriteLine("5 - O produto escalar entre dois vetores");
                Console.WriteLine("6 - Dado um número de CPF, verificar se este número é válido");
                Console.WriteLine("0 - Encerrar programa");
                Console.Write("\nOpção: ");
                string opcao = Console.ReadLine();
                switch(opcao)
                {
                    case "1":
                        Questao1.Rodar();
                        VoltarAoMenu();
                        break;
                    case "2":
                        Questao2.Rodar();
                        VoltarAoMenu();
                        break;
                    case "3":
                        Questao3.Rodar();
                        VoltarAoMenu();
                        break;
                    case "4":
                        Questao4.Rodar();
                        VoltarAoMenu();
                        break;
                    case "5":
                        Questao5.Rodar();
                        VoltarAoMenu();
                        break;
                    case "6":
                        Questao6.Rodar();
                        VoltarAoMenu();
                        break;
                    case "0":
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (continua);
        }
        public static void VoltarAoMenu()
        {
            Console.WriteLine("\nAperte alguma tecla para voltar ao menu");
            Console.ReadKey();
        }
    }
}
