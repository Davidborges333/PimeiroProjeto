namespace PimeiroProjeto
{
    internal class Program
    {
        public static int Campos { get; private set; }

        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade");
            cidade = Console.ReadLine();

            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("Idade:{0}", idade);
            Console.WriteLine("Cidade:{0}", cidade);
            Console.WriteLine("Nome:{0} \n {1} anos \n de:{2}", nome, idade, cidade);
        }
    }
} 