using System;
using System.Net.Mail;
namespace SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            // Valida consistencia
            if (!Email.Contains("@"))
                return "Cliente com e-mail invalido";

            if (CPF.Length != 11)
                return "Cliente com CPF invalido";

            // Grava em BD
            using (var cn = SqlConnection())
            {
                // Criar command
                // Parametros
                // Executar Query
            }

            // Envio de email.
            var mail = new MailMessage("empresa@emrpesa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabens, esta cadastrado!";
            client.Send(mail);

            return "Cliente cadastrado com sucesso!";
        }

        private IDisposable SqlConnection()
        {
            throw new NotImplementedException();
        }
    }
}