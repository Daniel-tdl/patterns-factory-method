using System;
using factory.SemPatterns;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tipo de plano.");
            string tipoPlano = Console.ReadLine();

            Console.Write("Informe a quantidade de pessoas.");
            string qutPessoas = Console.ReadLine();

            Console.Write("Informe a quantidade de pessoas maiores de 30 anos.");
            string qutMaioresTrintaAnos = Console.ReadLine();

            planoSaude plano = new planoSaude(tipoPlano, Int32.Parse(qutPessoas), Int32.Parse(qutMaioresTrintaAnos));

            // planoSaudeFactory planoSaudeFactory = new planoSaudeFactory(tipoPlano, Int32.Parse(qutPessoas), Int32.Parse(qutMaioresTrintaAnos));
            // planoSaudeProduct plano = planoSaudeFactory.BuscarPlanoSaude();

            Console.WriteLine("\nOs detalhes do seu plano:");
            Console.WriteLine("   -> {0}", plano.descricaoPlano());
            Console.WriteLine("   -> Voce tem direito ao plano: {0}", plano.podeFazerPlano());
            Console.WriteLine("   -> Valor do plano: {0} reais\n", plano.retornarValorPlano());
        }

        
    }
}
