using System;
namespace InheritanceProj
{
    public class TextNotification : Notification
    {
        public string Recipient { get; set; }
        public string SmsProvider { get; set; }

        public TextNotification(string subject, string body, string recipient, string smsprovider): base(subject, body)
        {
            Subject = subject;
            Body = body;
            Recipient = recipient;
            SmsProvider = smsprovider;
        }

        public override void Transport()
        {
            Console.WriteLine($"{Subject}'s message - {Body} - is going to {Recipient} whose service is proivded by {SmsProvider}.");
        }
    }
}