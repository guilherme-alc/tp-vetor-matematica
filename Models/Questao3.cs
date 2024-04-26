namespace TrabalhoPratico.Models
{
    internal class Questao3
    {
        public static void Rodar()
        {
            Console.Clear();
            Console.WriteLine("O módulo do vetor é a raiz quadrada da soma dos seus componentes cada um elevado ao quadrado");
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
            double x = 0, y = 0, z = 0;
            try
            {
                if (dimensao == "2d")
                {
                    Console.WriteLine("\nDigite os valores do vetor");
                    Console.Write("X: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    y = double.Parse(Console.ReadLine());

                }
                else if (dimensao == "3d")
                {
                    Console.WriteLine("\nDigite os valores do vetor");
                    Console.Write("X: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    y = double.Parse(Console.ReadLine());
                    Console.Write("Z: ");
                    z = double.Parse(Console.ReadLine());
                }
                CalculaVetor(x, y, z, dimensao);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de entrada inválida");
            }
        }
        public static void CalculaVetor(double x, double y, double z, string dimensao)
        {
            if (dimensao == "2d")
            {
                Console.WriteLine("\nA formula é usada é |v| = Vx²+y²");
                double soma = Math.Pow(x, 2) + Math.Pow(y, 2);
                soma = Math.Sqrt(soma);
                Console.WriteLine($"O módulo do vetor ({x},{y}) é = {soma:F3}");
            }
            else if (dimensao == "3d")
            {
                Console.WriteLine("\nA formula é usada é |v| = Vx²+y²+z²");
                double soma = Math.Pow(2, x) + Math.Pow(2, y) + Math.Pow(2, z);
                soma = Math.Sqrt(soma);
                Console.WriteLine($"O módulo do vetor ({x},{y},{z}) é = {soma:F3}");
            }
        }
    }
}
