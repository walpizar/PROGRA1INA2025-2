using System.Net;
using System.Net.Mail;

namespace Services
{
    public static class clsEmailHelper
    {
        public static void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            var fromAddress = new MailAddress("tucorreo@dominio.com", "Sistema Donaciones");
            var toAddress = new MailAddress(destinatario);

            const string fromPassword = "TU_CONTRASEÑA"; // ⚠️ Usa configuración segura
            string subject = asunto;
            string body = cuerpo;

            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",   // Cambia según tu proveedor
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            })
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
