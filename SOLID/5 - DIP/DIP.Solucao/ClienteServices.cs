using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        /// <summary>
        /// Dependendo de uma abstração e não uma implementação
        /// Injeção de dependencia.
        /// </summary>
        /// <param name="clienteRepository">Instancia de Repository</param>
        /// <param name="emailServices">Instancia de email Services</param>
        public ClienteServices(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            // Eu não sei qual é a classe mas tenho um contrado que diz que implementa.
            _clienteRepository.AdicionarCliente(cliente);
            _emailServices.Enviar("empresa@gmail.com", cliente.Email.Endereco, "Bem Vindo", "Hello World");

            return "Daos Adicionados com sucesso!";
        }
    }

    public class TesteDip
    {
        public TesteDip()
        {
            var cliente = new ClienteServices(new ClienteRepository(), new EmailService());

            var cliente2 = new ClienteServices(new ClienteRepository2(), new EmailService());
        }
    }
}