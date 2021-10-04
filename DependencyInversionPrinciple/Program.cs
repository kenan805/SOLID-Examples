using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{

    // Dependency Inversion Principle
    public interface IMessage
    {
        void SendMessage();
    }

    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Send email.");
        }
    }

    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Send sms.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IMessage> messages = new List<IMessage>
            {
                new SMS(),
                new Email(),
            };
            Notification notification = new Notification(messages);
            notification.Send();
        }
    }

    public class Notification
    {
        private List<IMessage> _messages;

        public Notification(List<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
