namespace PrimieroEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Coloque o o produto desejado, o preço dele e a quantidade em estoque");
            string[] entrada = Console.ReadLine().Split(' ');
            produto.Nome = entrada[0];
            produto.Preco = double.Parse(entrada[1]);
            produto.Qunt = int.Parse(entrada[2]);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Dados atulizados: " + produto);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Dados atulizados: " + produto);
        }
    }
}
