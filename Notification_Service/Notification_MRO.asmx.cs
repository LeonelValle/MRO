using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Services;

namespace Notification_Service
{
    /// <summary>
    /// Summary description for Notification_MRO
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Notification_MRO : System.Web.Services.WebService
    {

        [WebMethod]
        public void Notification_Caducidad(int test)
        {
            MailMessage msg = new MailMessage("scanner@masterworkelectronics.com", "leonel.valle@masterworkelectronics.com");
            msg.Subject = "MRO item next to expiration ";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("test: ");
            sb.AppendLine("Mobile Number: ");
            sb.AppendLine("Email:");
            sb.AppendLine("Drop Downlist Name:");
            msg.Body = sb.ToString();

            SmtpClient SmtpClient = new SmtpClient();
            SmtpClient.Host = "192.168.1.4";
            SmtpClient.UseDefaultCredentials = true;
            SmtpClient.Port = 25;
            SmtpClient.EnableSsl = false;
            SmtpClient.Send(msg);
        }
    }
}
