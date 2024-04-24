namespace TrabalhoPratico.Models
{
    internal class Questao5
    {
        public static void Rodar()
        {
            Console.Clear();
            Console.WriteLine("O vetor a ser calculado é 2d ou 3d?");
            string dimensao = Console.ReadLine().ToLower();
            int n = 0;
            if (dimensao == "2d")
            {
                n = 2;
                DefineVetor(dimensao, n);

            }
            else if (dimensao == "3d")
            {
                n = 3;
                DefineVetor(dimensao, n);
            }
            else
            {
                Console.WriteLine("\nOpção inválida. Digite 2d ou 3d");
            }
        }
        public static void DefineVetor(string dimensao, int n)
        {
            double xA = 0, yA = 0, zA = 0, xB = 0, yB = 0, zB = 0;
            double[] vetorA = new double[n];
            double[] vetorB = new double[n];
            try
            {
                if (dimensao == "2d")
                {
                    Console.WriteLine("\nDigite os valores do vetor A");
                    Console.Write("X: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yA = double.Parse(Console.ReadLine());

                    vetorA[0] = xA;
                    vetorA[1] = yA;

                    Console.WriteLine("\nAgora os valores do vetor B");
                    Console.Write("X: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yB = double.Parse(Console.ReadLine());

                    vetorB[0] = xB;
                    vetorB[1] = yB;
                }
                else if (dimensao == "3d")
                {
                    Console.WriteLine("\nDigite os valores do vetor A");
                    Console.Write("X: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yA = double.Parse(Console.ReadLine());
                    Console.Write("Z: ");
                    zA = double.Parse(Console.ReadLine());

                    vetorA[0] = xA;
                    vetorA[1] = yA;
                    vetorA[2] = zA;

                    Console.WriteLine("\nAgora digite os valores do vetor B");
                    Console.Write("X: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yB = double.Parse(Console.ReadLine());
                    Console.Write("Z: ");
                    zB = double.Parse(Console.ReadLine());


                    vetorB[0] = xB;
                    vetorB[1] = yB;
                    vetorB[2] = zB;
                }
                CalcularProdutoEscalar(vetorA, vetorB, n);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de entrada inválida");
            }
        }

        static void CalcularProdutoEscalar(double[] vetorA, double[] vetorB, int n)
        {
            double produtoEscalar = 0;

            // Calculando o produto escalar
            for (int i = 0; i < vetorA.Length; i++)
            {
                produtoEscalar += vetorA[i] * vetorB[i];
            }
            Console.WriteLine($"\nO produto escalar entre A e B é = {produtoEscalar}");
        }
    }
}
