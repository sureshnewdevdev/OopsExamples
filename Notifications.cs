using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleNotification
{
    public interface ISendMessage
    {
        public  string Message { get; set; }
        public string Send();
    }

 
    public class Notifications
    {

        public void SendMessage(ISendMessage sendMessage)
        {
            // Send message to SMS
            sendMessage.Send();
        }
    }

    public class SMSMessage : ISendMessage
    {
        public string Message { get; set; }
        public string Send()
        {
            string str = $"Message {Message} sent via SMS";
            return str;
        }
    }


    public class EmailMessage : ISendMessage
    {
        public string Message { get; set; }

        public string Send()
        {
            string str = $"Message {Message} sent via EMail";
            return str;
        }

    }

    public class WhatsAppMessage : ISendMessage
    {
        public string Message { get; set; }
        public string Send()
        {
            string str = $"Message {Message} sent via WhatsApp";
            return str;
        }
    }

    public class Sender
    {
        public static void Main(string[] args)
        {
            SMSMessage smsMessage = new SMSMessage();
            smsMessage.Message = "Hello World";
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.Message = "Hello World";


            Notifications notifications = new Notifications();
            notifications.SendMessage(emailMessage);

        }
    }
}


























