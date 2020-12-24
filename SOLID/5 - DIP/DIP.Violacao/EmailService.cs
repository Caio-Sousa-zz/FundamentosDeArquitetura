using System.Net.Mail;

namespace SOLID.DIP.Violacao
{
    public static class EmailService
    {
        public static void Enviar(string de, string para, string assunto, string messagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = messagem;
            client.Send(mail);
        }
    }
}