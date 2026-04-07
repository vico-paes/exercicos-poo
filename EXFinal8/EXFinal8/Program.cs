using EXFinal8.Entidades;

namespace EXFinal8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Aniversário: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, nascimento);
            Console.WriteLine();

            Console.WriteLine("Entre com os dados do pedido");
            Console.Write("Status: "); //nao sei como colcoar o status aqui, nao sei se e pra deixar padrao ou puxar algo//
            //lembrei olhado o word de enumerações, nao sei se tem outro jeito de fazer//
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());
            
            Console.Write("Quantos itens no pedido? ");
            int quantidade = int.Parse(Console.ReadLine());
            Pedido pedido = new Pedido(DateTime.Now, StatusPedido.Processando, cliente);
            Console.WriteLine();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Entre com o {i}# item");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto, precoProduto);
                pedido.AddItem(new PedidoItem(quantidadeProduto, precoProduto, produto));
            }
            Console.WriteLine();
            Console.WriteLine(pedido);
        }
    }
}
