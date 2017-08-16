using System;
namespace InheritanceProj
{
    public class NoTransportException : Exception
    {
        public NoTransportException() : base("You're not Jason Statham!"){}
    }
}