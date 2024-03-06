using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
  public class VideoEncoder
  {
    private readonly IList<INotificationChannel> _notificationChannels;
    public VideoEncoder()
    {
      _notificationChannels = new List<INotificationChannel>();
    }
    public void Encode()
    {
      // video encoding logic goes here
      foreach (var channel in _notificationChannels)
        channel.Send(new Message());
    }

    public void RegisterNotificationChannel(INotificationChannel channel)
    {
      _notificationChannels.Add(channel);
    }
  }
}