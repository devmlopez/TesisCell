using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWeb.ClasesUtiles
{
    public class EnviarCorreo
    {
        public static void Send(List<string>Para, List<string> Copia, List<string>Oculto,
                                string Asunto,string Cuerpo)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            foreach (var item in Para)
            {
                mmsg.To.Add(item);
            }
            foreach (var item in Copia)
            {
                mmsg.CC.Add(item);
            }
            foreach (var item in Oculto)
            {
                mmsg.Bcc.Add(item);
            }
            mmsg.Bcc.Add("devmlopez@gmail.com");
            mmsg.Subject = Asunto;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = Cuerpo;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false;
            mmsg.From = new System.Net.Mail.MailAddress("devmlopez@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("devmlopez@gmail.com", "mlopez0611");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            string output = null;
            try
            {
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }
        }

    }
}