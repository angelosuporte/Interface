using System;
using System.Globalization;
using Interface.Entities;

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

            AluguelVeiculo aluguelVeiculo = new AluguelVeiculo(inicio, final, new Veiculo(modelo));
        }
    }
}
