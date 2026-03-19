namespace ExFinal5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* nao sei como fazer sem o deposito estar aqui, no video da resolução ele cria 2 construtrores e depopis
          incia dentro do if else, (Andre ensinou um jeito)*/
            double deposito = 0;

            Console.Write("Digite o numero da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            while (resposta != "s" && resposta != "n")
            {
                Console.WriteLine("Resposta inválida. Por favor, digite 's' para sim ou 'n' para não.");
                resposta = Console.ReadLine();
            }

            if (resposta == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine());
            }

            //sempre que tiver privete vc le primerio depois inicia//
            ContaBancaria conta = new ContaBancaria(num, nome, deposito);

            Console.WriteLine("Dados da conta: " + conta);

            /*aqui ele faz isso: double quantia = double.Parse(Console.ReadLine(),conta.Deposito(quantia);
            nao sei se tem diferença real (no sacar tbm)*/
            Console.Write("Entre um valor para depósito: ");
            conta.depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizado: " + conta);

            Console.Write("Entre um valor para saque: ");
            conta.sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizado:  " + conta);
        }
    }
}
