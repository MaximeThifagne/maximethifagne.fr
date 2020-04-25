using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DataAccess.Constant;
using MaximeThifagne.DTO;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace MaximeThifagne.DataAccess.Command.Implementation
{
    public class ContactCommand : IContactCommand
    {
        public bool SendMessage(ContactDto message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message.UserEmail));
            ConfigurationManager.RefreshSection("appSettings");

            SmtpClient smtpClient = GetSmtpClient();
            MailMessage mail = new MailMessage(ContactConstant.SenderAdress, ContactConstant.RecipientAdress);

            mail.Subject = ContactConstant.MessageSubject + message.UserName;
            mail.Body = message.UserMessage + message.UserPhoneNumber + message.UserWebSite;

            try
            {
                smtpClient.Send(mail);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        private static SmtpClient GetSmtpClient()
        {
            SmtpClient client = new SmtpClient(ContactConstant.SmtpHost);

            client.UseDefaultCredentials = true;
            client.Credentials = new NetworkCredential(ContactConstant.SmtpUser, ContactConstant.SmtpPassword);
            client.Port = ContactConstant.SmtpPort;
            return client;
        }
    }
}
