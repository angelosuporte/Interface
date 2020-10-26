using System;
using System.Globalization;
using Interface.Entities;
using Interface.Service;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do aluguel");
            Console.Write("Modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Retirada (dd/MM/yyyy hh:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolucao (dd/MM/yyyy hh:mm): ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            AluguelVeiculo aluguelVeiculo = new AluguelVeiculo(inicio, final, new Veiculo(modelo));

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new ImpostoServicoBrasil());//Injeção de dependência pela classe Program na classe ServicoAluguel utilizando a abstração(interface)
            servicoAluguel.ProcessandoNotaFiscal(aluguelVeiculo);
            Console.WriteLine("Nota fiscal: ");
            Console.WriteLine(aluguelVeiculo.NotaFiscal);
            Console.ReadKey();
        }
    }
}
