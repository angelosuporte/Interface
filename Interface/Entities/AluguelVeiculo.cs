using System;

namespace Interface.Entities
{
    class AluguelVeiculo
    {
        public DateTime Inicio { get; set; }
        public DateTime Devolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public NotaFiscal NotaFiscal { get; set; }

        //Não será necessário no construtor a NotaFiscal porque ela só será gerada no processamento para realizar o pagamento do aluguel
        public AluguelVeiculo(DateTime inicio, DateTime devolucao, Veiculo veiculo)
        {
            Inicio = inicio;
            Devolucao = devolucao;
            Veiculo = veiculo;
           
        }
    }
}
