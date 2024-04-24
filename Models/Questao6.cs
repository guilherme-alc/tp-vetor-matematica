namespace TrabalhoPratico.Models
{
    internal class Questao6
    {
        public static void Rodar()
        {
            Console.Clear();
            string cpf_usuario;
            List<int> vetor_cpf_original = new List<int>();
            List<int> vetor_padrao = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            List<int> vetor_cpf_criado = new List<int>();
            Console.WriteLine("Digite 11 dígitos do CPF (Somente os números): ");
            try
            {
                cpf_usuario = Console.ReadLine().Replace(".", "").Replace("-", "").Trim();
                if (cpf_usuario.Length != 11)
                {
                    Console.WriteLine("CPF deve ter 11 dígitos");
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                        vetor_cpf_criado.Add(cpf_usuario[i] - '0');
                    for (int i = 0; i < cpf_usuario.Length; i++)
                        vetor_cpf_original.Add(cpf_usuario[i] - '0');
                    CalculaDigitos(vetor_padrao, vetor_cpf_criado);
                    CalculaDigitos(vetor_padrao, vetor_cpf_criado);
                    VerificaCPF(vetor_cpf_criado, vetor_cpf_original);

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nTipo de entrada inválida");
            }
        }
        public static void CalculaDigitos(List<int> padrao, List<int> cpf_usuario)
        {
            int soma = 0, res;
            for (int i = 0; i < cpf_usuario.Count; i++)
            {
                int mult = cpf_usuario[i] * padrao[i];
                soma += mult;
            }
            res = soma % 11;
            if (res == 1 || res == 0)
                cpf_usuario.Add(0);
            else
                cpf_usuario.Add(11 - res);
            padrao.Insert(0, 11);

        }
        public static void VerificaCPF(List<int> cpf_criado, List<int> cpf_origem)
        {

            if (cpf_criado[10] == cpf_origem[10] && cpf_criado[9] == cpf_origem[9])
                Console.WriteLine("\nCPF VÁLIDO");
            else
                Console.WriteLine("\nCPF INVÁLIDO");
        }
    }
}
