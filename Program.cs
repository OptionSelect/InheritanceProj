using System;

namespace InheritanceProj
{
    class Program
    {
        static void Main(string[] args)
        {
           var EmailNoti = new EmailNotification("Brandyn", "What's up?", "Jake", "Microsoft");
           var TextNoti = new TextNotification("Brandyn", "Jakooooooda", "Jake", "Sprint");

           EmailNoti.Transport();
           TextNoti.Transport();
        }
    }
}
