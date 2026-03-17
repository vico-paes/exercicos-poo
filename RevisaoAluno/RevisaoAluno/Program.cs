namespace RevisaoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();
            Console.WriteLine("Digite o nome do aluno");
            a1.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite as tres notas");
            string[] notas = Console.ReadLine().Split(' ');
            a1.Nota1 = double.Parse(notas[0]);
            a1.Nota2 = double.Parse(notas[1]);
            a1.Nota3 = double.Parse(notas[2]);
            Console.WriteLine();

            Console.WriteLine("Sua nota final e: " + a1.NotaFinal());

            if (a1.Aprovado())
            {
                Console.WriteLine("Parabens voce foi aprovado");
            }
            else
            {
                Console.WriteLine("Voce precisa de " + a1.PontosFaltando() + " pontos para ser aprovado");
            }

            Console.WriteLine();
            Console.WriteLine("Deseja fazer de novo s ou n");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Muito obrigado");
            }
        }
    }
}

   
