using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
  public  class EMailClass
    {
         public virtual bool sendMail () {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("anamika.sawhney22@gmail.com");
            mail.To.Add("anamika_sawhney@gmail.com");
            //mail.Subject = "Customer Inserted";
            mail.Body = "Customer inserted successfully";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("", "");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            return true;

        }
    }
}