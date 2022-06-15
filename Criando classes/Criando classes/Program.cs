namespace Criando_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Pessoas pessoa1 = new Pessoas();
          Pessoas pessoa2 = new Pessoas();

            pessoa1.nome = "Maria";
            pessoa2.idade = 17;
            pessoa2.nome = "João";
            pessoa2.idade = 16;

            if (pessoa1.idade < pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }
        }
    }
}