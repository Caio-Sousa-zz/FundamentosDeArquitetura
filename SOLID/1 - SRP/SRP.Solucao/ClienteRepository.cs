namespace SOLID.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente c)
        {
            // Grava em BD
            using (var cn = SqlConnection())
            {
                // Criar command
                // Parametros
                // Executar Query
            }
        }

        private System.IDisposable SqlConnection()
        {
            throw new System.NotImplementedException();
        }
    }
}