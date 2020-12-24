namespace SOLID.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente c)
        {
            if (!c.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(c);

            EmailService.Enviar("empresa@gmail.com", c.Email.Endereco, "Bem Vindo", "");

            return "Cliente cadastrado com sucesso";
        }
    }
}