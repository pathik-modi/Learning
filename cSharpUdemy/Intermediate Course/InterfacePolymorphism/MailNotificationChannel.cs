using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
  public class MailNotificationChannel : INotificationChannel
  {
    public void Send(Message message)
    {
      System.Console.WriteLine("sending mail...");
    }
  }
}