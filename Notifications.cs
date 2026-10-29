using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleNotification
{
    public interface ISendMessage
    {
        public string Send(string message);
    }
    public class Notifications
    {

        public void SendMessage(ISendMessage sendMessage, string msg)
        {
            // Send message to SMS
            sendMessage.Send(msg);
        }
    }

    public class SMSMessage : ISendMessage
    {
        public string Send(string message)
        {
            string str = $"Message {message} sent via SMS";
            return str;
        }
    }


    public class EmailMessage : ISendMessage
    {
        public string Send(string message)
        {
            string str = $"Message {message} sent via EMail";
            return str;
        }

    }

    public class WhatsAppMessage : ISendMessage
    {
        public string Send(string message)
        {
            string str = $"Message {message} sent via WhatsApp";
            return str;
        }
    }

    public class Sender
    {
        public static void Main(string[] args)
        {
            SMSMessage smsMessage = new SMSMessage();
            EmailMessage emailMessage = new EmailMessage();


            Notifications notifications = new Notifications();
            notifications.SendMessage(emailMessage, "Good Morning");

        }
    }
}


























