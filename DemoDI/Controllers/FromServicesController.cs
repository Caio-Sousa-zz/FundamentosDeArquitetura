using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        // Injeção de dep. por parametro
        // Não é recomendado
        // Se não puder mexer no construtor fazer desta forma
        // Injetar dependencia diretamente no método
        public void Index([FromServices] IClienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}