namespace SOLID.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContarPoupanca(this DebitoConta debitoConta)
        {
            // logica para poupança
            return debitoConta.FormatarTransacao();
        }
    }
}