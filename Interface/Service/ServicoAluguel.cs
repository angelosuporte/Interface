using System;
using Interface.Entities;

namespace Interface.Service
{
    class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        public ServicoAluguel(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessandoNotaFiscal(AluguelVeiculo aluguelVeiculo)
        {

        }
    }
}
