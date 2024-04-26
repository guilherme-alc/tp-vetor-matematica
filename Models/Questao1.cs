namespace TrabalhoPratico.Models
{
    public class Questao1
    {
        public static void Rodar()
        {
            Console.Clear();
            Console.WriteLine("A soma de dois vetores é feita somando as componentes correspondentes dos vetores individuais.");
            Console.WriteLine("Exemplo V + U = (Vx + Ux, Vy + Uy, Vz, Uz)");
            Console.WriteLine("\nO vetor a ser calculado é 2d ou 3d?");
            string dimensao = Console.ReadLine().ToLower();
            int n = 0;
            if(dimensao == "3d")
            {
                n = 3;
            } else if (dimensao == "2d")
            {
                n = 2;
            } else
            {
                Console.WriteLine("\nDimensão inválida.");
                return;
            }
            List<double> al1 = new List<double>();
            Console.WriteLine("\nPreencha os componentes do primeiro vetor com números reais");
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write("Digite o valor de X: ");
                }
                else if (i == 1)
                {
                    Console.Write("Digite o valor de Y: ");
                }
                else
                {
                    Console.Write("Digite o valor de Z: ");
                }
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int componente))
                {
                    al1.Add(componente);
                }
                else
                {
                    Console.WriteLine($"\n\"{entrada}\" não é um número válido");
                    return;
                }
            }
            Console.WriteLine("\nPreencha os componentes do segundo vetor com números reais");
            List<double> al2 = new List<double>();
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    Console.Write("Digite o valor de X: ");
                }
                else if (j == 1)
                {
                    Console.Write("Digite o valor de Y: ");
                }
                else
                {
                    Console.Write("Digite o valor de Z: ");
                }
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int componente))
                {
                    al2.Add(componente);

                }
                else
                {
                    Console.WriteLine("\nNão é um número válido");
                    Console.WriteLine($"\n{entrada} não é um número válido");
                    return;
                }
            }
            Console.WriteLine("\nVetor Resultante:");
            List<double> alResultado = new List<double>();
            for (int k = 0; k < n; k++)
            {
                double soma = al1[k] + al2[k];
                alResultado.Add(soma);
            }
            Console.Write("V = ");
            if(n == 2)
            {
                Console.Write($"({alResultado[0]}, {alResultado[1]})");
            }
            else
            {
                Console.Write($"({alResultado[0]}, {alResultado[1]}, {alResultado[2]})");
            }
            Console.WriteLine();
        }
    }
}
