namespace SOLID.DIP.Violacao
{
    // Alto Nivel
    public class ClienteService
    {
        public string AdicionarCliente(Cliente c)
        {
            if (!c.Validar())
                return "Dados inválidos";

            // Baixo nivel
            // Acoplamento
            var repo = new ClienteRepository();
            repo.AdicionarCliente(c);

            EmailService.Enviar("empresa@gmail.com", c.Email.Endereco, "Bem Vindo", "");

            return "Cliente cadastrado com sucesso";
        }
    }
}