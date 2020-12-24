namespace SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            { 
                // Debito Conta Corrente
            }
            if (tipoConta == TipoConta.Poupanca)
            { 
                // Validar aniversario, Debito conta poupança 
            }
        }
    }
}