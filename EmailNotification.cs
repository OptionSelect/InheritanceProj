using System;
namespace InheritanceProj
{
    public class EmailNotification : Notification
    {
        public string Recipient { get; set; }
        public string SmtpProvider { get; set; }

        public EmailNotification(string subject, string body, string recipient, string smtpprovider): base(subject, body)
        {
            Subject = subject;
            Body = body;
            Recipient = recipient;
            SmtpProvider = smtpprovider;
        }

        public override void Transport()
        {
            Console.WriteLine($"{Subject}'s message - {Body} - is going to {Recipient} whose service is proivded by {SmtpProvider}.");
        }
    }
}