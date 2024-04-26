namespace TrabalhoPratico.Models
{
    internal class Questao4
    {
        public static void Rodar()
        {
            Console.Clear();
            Console.WriteLine("Para determinar o vetor AB você deve subtrair os componentes do vetor B pelos componentes do vetor A");
            Console.WriteLine("O vetor resultante é dado por:");
            Console.WriteLine("\t\tAB = (Bx - Ax, By - Ay, Bz - Az)");
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
            try
            {
                double xA = 0, yA = 0, zA = 0, xB = 0, yB = 0, zB = 0;
                if (dimensao == "2d")
                {
                    Console.WriteLine("\nDigite os valores do vetor A");
                    Console.Write("X: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yA = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nAgora digite os valores do vetor B");
                    Console.Write("X: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yB = double.Parse(Console.ReadLine());

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
                    Console.WriteLine("\nAgora digite os valores do vetor B");
                    Console.Write("X: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    yB = double.Parse(Console.ReadLine());
                    Console.Write("Z: ");
                    zB = double.Parse(Console.ReadLine());
                }
                CalculaVetor(xA, yA, zA, xB, yB, zB, dimensao);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de entrada inválida");
            }
        }
        public static void CalculaVetor(double xA, double yA, double zA, double xB, double yB, double zB, string dimensao)
        {
            if (dimensao == "2d")
            {
                double xAB = xB - xA;
                double yAB = yB - yA;
                Console.WriteLine($"\nVetor AB = ({xAB},{yAB})");
            }
            else if (dimensao == "3d")
            {
                double xAB = xB - xA;
                double yAB = yB - yA;
                double zAB = zB - zA;
                Console.WriteLine($"\nVetor AB = ({xAB},{yAB},{zAB})");
            }
        }
    }
}
