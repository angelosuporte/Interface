using System;
using Interface.Entities;

namespace Interface.Service
{
    class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private IImpostoServico _impostoServico;

        public ServicoAluguel(double precoPorHora, double precoPorDia, IImpostoServico impostoServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _impostoServico = impostoServico; //feito inversão de controle por injeção de dependência

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

            double imposto = _impostoServico.Imposto(pagamentoBasico);
            aluguelVeiculo.NotaFiscal = new NotaFiscal(pagamentoBasico, imposto);
        }
    }
}
