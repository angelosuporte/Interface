﻿namespace Interface.Service
{
    class ImpostoServicoBrasil : IImpostoServico //<--realização da interface, agora IImpostoServico será uma abstração da classe ImpostoServiçoBrasil
    {
        public double Imposto(double quantia)
        {
            if (quantia <= 100.0)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
