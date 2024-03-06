﻿namespace InterfacePolymorphism;

class Program
{
  static void Main(string[] args)
  {
    var encoder = new VideoEncoder();
    encoder.RegisterNotificationChannel(new MailNotificationChannel());
    encoder.RegisterNotificationChannel(new SmsNotificationChannel());
    encoder.Encode();
  }
}
