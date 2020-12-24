﻿namespace SOLID.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negocia para debito em conta investimento.
            return debitoConta.FormatarTransacao();
        }
    }
}