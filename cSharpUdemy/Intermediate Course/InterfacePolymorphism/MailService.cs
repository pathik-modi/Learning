using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
  public class MailService
  {
    public void Send(Mail mail)
    {
      System.Console.WriteLine("Sending mail...");
    }
  }
}