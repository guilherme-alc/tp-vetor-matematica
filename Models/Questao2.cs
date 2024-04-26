namespace TrabalhoPratico.Models
{
    internal class Questao2
    {
        public static void Rodar()
        {
            Console.Clear();
            Console.WriteLine("A multiplicação de um escalar por um vetor é feita multiplicando cada componente do vetor pelo escalar");
            Console.WriteLine("Exemplo se você tiver um vetor V e um escalar \"a\", então a multiplicação a.V é dada por:");
            Console.WriteLine("\n\t\ta.V = (a.Vx, a.Vy, a.Vz)");
            Console.WriteLine("\nO vetor a ser calculado é 2d ou 3d?");
            string dimensao = Console.ReadLine().ToLower();
            if (dimensao == "2d")
            {
                DefineVetor(dimensao);

            }
            else if (dimensao == "3d")
            {
                DefineVetor(dimensao);
            }
            else
            {
                Console.WriteLine("\nOpção inválida. Digite 2d ou 3d");
            }

        }
        public static void DefineVetor(string dimensao)
        {
            int x, y, z, k;
            List<int> new_vetor = new List<int>();
            try
            {
                if (dimensao == "2d")
                {
                    Console.Write("Digite o valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da escalar K: ");
                    k = int.Parse(Console.ReadLine());
                    new_vetor.Add(x * k);
                    new_vetor.Add(y * k);
                    Console.WriteLine("\nNovo Vetor: X   Y");
                    Console.Write("           ");
                    foreach (int i in new_vetor)
                    {
                        Console.Write(+i + "   ");
                    }
                }
                else if (dimensao == "3d")
                {
                    Console.Write("Digite o valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor de Z: ");
                    z = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da escalar K: ");
                    k = int.Parse(Console.ReadLine());
                    new_vetor.Add(x * k);
                    new_vetor.Add(y * k);
                    new_vetor.Add(z * k);
                    Console.WriteLine("\nNovo Vetor: X   Y    Z");
                    Console.Write("           ");
                    foreach (int i in new_vetor)
                    {
                        Console.Write(+i + "   ");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de entrada inválida");
            }

        }
    }
}
