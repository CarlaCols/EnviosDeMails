using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace EnviosMails
{
    class SendMail
    {
        public void sendMail(Button button,EmailBody emailBody)
        {
            string server = "smtp.office365.com";
            int port = 587;

            //string server = "smtp.gmail.com";
            //int port = 587;

            //Se crea el Mensaje
            MimeMessage message = new MimeMessage();
            
            //Indica de que buzon se esta enviando el mail  (DE:)
            message.From.Add(MailboxAddress.Parse(emailBody.mailUser));

            //Indica a que buzon se esta enviando el mail (PARA:)
            message.To.Add(MailboxAddress.Parse(emailBody.To));

            //Indica a que buzon se es enviand que esta en Copia (Cc)
            if (emailBody.mailCc != string.Empty)
            {
                message.Cc.Add(MailboxAddress.Parse(emailBody.mailCc));
            }

            //Indica a que buzon se esta enviando el mail en Copia Oculta Cco(message.Bcc)
            if (emailBody.mailCco != string.Empty)
            {
                message.Bcc.Add(MailboxAddress.Parse(emailBody.mailCco));
            }
          
            //Asunto del Mail
            message.Subject = "Confirmacion de Tickets";

            //Cuerpo del mail
            BodyBuilder messageBody = new BodyBuilder();
            
            messageBody.HtmlBody = @"Estimados, "+
            "<p>El sector interviniente informa que los siguientes tickets se encuentran resueltos, aguardamos su confirmacion para proceder al cierre de los mismos." +

            "<table border=0 width=1200> " +
                "<tr style='background-color:#0072C6;color:white;' >" +
                    "<th>Mail</th>" +
                    "<th>Abierto Por</th>" +
                    "<th>Ticket </th>" +
                    "<th>Titulo</th> " +
                "</tr>" +
                    "<td align=center>" + emailBody.To+ "</td>" +
                    //"<td align=center>" + emailBody.IdInteraction+"</td>" +
                    "<td align=center>" + emailBody.Message+"</td> " +
                    //"<td align=center>" + emailBody.Title + "</td> " +
                 "</tr>" +
            "</table>" ;

            message.Body = messageBody.ToMessageBody();

            //Envio del mail
            SmtpClient clientSmtp = new SmtpClient();

                try
                {
                    clientSmtp.CheckCertificateRevocation = false;
                    clientSmtp.Connect(server, port, MailKit.Security.SecureSocketOptions.StartTls);
                    clientSmtp.Authenticate(emailBody.mailUser,emailBody.mailPass);
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
        public void sendMail(Button button, EmailBody emailBody, dateToSendEmails DataEmail)
        {
            string server = "smtp.office365.com";
            int port = 587;

            //string server = "smtp.gmail.com";
            //int port = 587;

            //Se crea el Mensaje
            MimeMessage message = new MimeMessage();

            //Indica de que buzon se esta enviando el mail  (DE:)
            message.From.Add(MailboxAddress.Parse(emailBody.mailUser));

            //Indica a que buzon se esta enviando el mail (PARA:)
            message.To.Add(MailboxAddress.Parse(emailBody.To));

            //Indica a que buzon se es enviand que esta en Copia (Cc)
            if (emailBody.mailCc != string.Empty)
            {
                message.Cc.Add(MailboxAddress.Parse(emailBody.mailCc));
            }

            //Indica a que buzon se esta enviando el mail en Copia Oculta Cco(message.Bcc)
            if (emailBody.mailCco != string.Empty)
            {
                message.Bcc.Add(MailboxAddress.Parse(emailBody.mailCco));
            }

            //Asunto del Mail
            message.Subject = "Confirmacion de Tickets";

            //Cuerpo del mail
            BodyBuilder messageBody = new BodyBuilder();

            string pp = string.Empty;
            foreach (var item in emailBody.groupDescriptions)
            {
                pp += @"<tr>"+
                    "<td align = center > " + emailBody.To + " </ td > " +
                    "<td align=center>" + item.IdInteraction + "</td>" +
                    "<td align=center>" + emailBody.Message + "</td> " +
                    "<td align=center>" + item.Title + "</td> " +
                    "</tr>";
            }


            messageBody.HtmlBody = @"Estimados, " +
            "<p>El sector interviniente informa que los siguientes tickets se encuentran resueltos, aguardamos su confirmacion para proceder al cierre de los mismos." +

            "<table border=0 width=1200> " +
                "<tr style='background-color:#0072C6;color:white;' >" +
                    "<th>Mail</th>" +
                    "<th>Abierto Por</th>" +
                    "<th>Ticket </th>" +
                    "<th>Titulo</th> " +
                "</tr>" +
                   pp +
                 "</tr>" +
            "</table>";

            message.Body = messageBody.ToMessageBody();

            //Envio del mail
            SmtpClient clientSmtp = new SmtpClient();

            try
            {
                clientSmtp.CheckCertificateRevocation = false;
                clientSmtp.Connect(server, port, MailKit.Security.SecureSocketOptions.StartTls);
                clientSmtp.Authenticate(emailBody.mailUser, emailBody.mailPass);
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
 