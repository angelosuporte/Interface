using System.Globalization;

namespace Interface.Entities
{
    class NotaFiscal
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public NotaFiscal(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }
        //Geralmente usamos um método, mas usar uma propriedade calculada conforme abaixo também é possível
        public double PagamentoTotal
        {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString()
        {
            return "Pagamento básico: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto: "
                +Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
