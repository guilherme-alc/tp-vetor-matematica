namespace TrabalhoPratico
{
    public class Questao1
    {
        public static void Rodar()
        {
            Console.Clear();
            List<double> al1 = new List<double>();
            Console.WriteLine("Preencha os componentes do primeiro vetor com números reais");
            for (int i = 0; i < 3; i++)
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
                    Console.WriteLine($"\n{entrada} não é um número válido");
                    return;
                }
            }
            Console.WriteLine("\nPreencha os componentes do segundo vetor com números reais");
            List<double> al2 = new List<double>();
            for (int j = 0; j < 3; j++)
            {
                if(j == 0)
                {
                    Console.Write("Digite o valor de X: ");
                } else if(j == 1)
                {
                    Console.Write("Digite o valor de Y: ");
                } else
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
            for (int k = 0; k < 3; k++)
            {
                double soma = al1[k] + al2[k];
                alResultado.Add(soma);
                Console.Write(soma + " ");
            }
        }
    }
}
