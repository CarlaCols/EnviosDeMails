using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace EnviosMails
{
    class SendMail
    {
        public void sendMail(Button button,string mailUser,string mailPass, string mailCc)
        {
            string server = "smtp.office365.com";
            int port = 587;

            //string server = "smtp.gmail.com";
            //int port = 587;

            //Se crea el Mensaje
            MimeMessage message = new MimeMessage();
            
                //Se indica desde donde se esta enviando
                message.From.Add(MailboxAddress.Parse(mailUser));

                //Se indica a donde se esta enviando
                message.To.Add(MailboxAddress.Parse("ina_987@hotmail.com"));

                //Se indica Quien estaq en Copia Cc
                if (mailCc != string.Empty)
                {
                message.Cc.Add(MailboxAddress.Parse(mailCc));
                }               

                //Asunto del Mail
                message.Subject = "Confirmacion de Tickets";

                //Cuerpo del mail
                BodyBuilder messageBody = new BodyBuilder();

                messageBody.HtmlBody = "Estimados, " +
                    "<p>El sector interviniente informa que los siguientes tickets se encuentran resueltos," +
                    " aguardamos su confirmacion para proceder al cierre de los mismos.";

                message.Body = messageBody.ToMessageBody();

                //Envio del mail
                SmtpClient clientSmtp = new SmtpClient();

                try
                {
                    clientSmtp.CheckCertificateRevocation = false;
                    clientSmtp.Connect(server, port, MailKit.Security.SecureSocketOptions.StartTls);
                    clientSmtp.Authenticate(mailUser, mailPass);
                    clientSmtp.Send(message);
                    MessageBox.Show("Mensajes Enviado");
                }
                catch (Exception ex)
                {
                    // En caso de error
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    clientSmtp.Disconnect(true);
                    clientSmtp.Dispose();
                }
               
            
           
        }
    }
}
 