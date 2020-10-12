using System;
using Interface.Entities;

namespace Interface.Service
{
    class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ImpostoServicoBrasil _impostoServicoBrasil = new ImpostoServicoBrasil();

        public ServicoAluguel(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessandoNotaFiscal(AluguelVeiculo aluguelVeiculo)
        {
            TimeSpan Duracao = aluguelVeiculo.Devolucao.Subtract(aluguelVeiculo.Inicio);

            double pagamentoBasico = 0.0;
            if (Duracao.TotalHours <= 12)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(Duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(Duracao.TotalDays);
            }

            double imposto = _impostoServicoBrasil.Imposto(pagamentoBasico);
            aluguelVeiculo.NotaFiscal = new NotaFiscal(pagamentoBasico, imposto);
        }
    }
}
