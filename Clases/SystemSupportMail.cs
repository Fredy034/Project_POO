using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsInn.Clases
{
    internal class SystemSupportMail : MailServices
    {
        public SystemSupportMail() 
        {
            senderMail = "fredyhernandoqs@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
