using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximeThifagne.DataAccess.Constant
{
    public static class ContactConstant
    {
        public static string SenderAdress => ConfigurationManager.AppSettings["senderAdress"];
        public static string RecipientAdress => ConfigurationManager.AppSettings["recipientAdress"];
        public static string SmtpHost => ConfigurationManager.AppSettings["smtpHost"];
        public static string SmtpUser => ConfigurationManager.AppSettings["smtpUserName"];
        public static string SmtpPassword => ConfigurationManager.AppSettings["smtpPassword"];
        public static int SmtpPort => Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]);
        public static string MessageSubject => "Contact de : ";
    }
}
