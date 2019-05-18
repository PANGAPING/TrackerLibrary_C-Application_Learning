using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        //wrap the logic of sendEmail.
        public static void SendEmail(string from,string to,string subject,string body) {

            MailAddress fromMailAddress = new MailAddress(from,"displayName");

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            //client.Port = 

            client.Send(mail);

        }
    }
}
