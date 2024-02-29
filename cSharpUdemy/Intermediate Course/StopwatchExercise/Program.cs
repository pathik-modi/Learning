namespace StopwatchExercise;
public class StopWatch
{
  private DateTime _start;
  private DateTime _stop;
  private bool _running;

  public void SetStartTime()
  {
    if (_running)
      throw new InvalidOperationException("Stopwatch is already running");

    _start = DateTime.Now;
    _running = true;
  }
  public void SetStopTime()
  {
    if (_running)
    {
      _stop = DateTime.Now;
      _running = false;
    }
    else
    {
      throw new InvalidOperationException("Stopwatch is already stopped");
    }

  }
  public TimeSpan Difference()
  {
    return _stop - _start;
  }
}
class Program
{
  static void Main(string[] args)
  {
    var stopwatch = new StopWatch();

    System.Console.WriteLine("Press 1 to start & 2 to stop");
    for (int i = 0; i < 4; i++)
    {
      var input = Convert.ToInt32(Console.ReadLine());
      switch (input)
      {
        case 1:
          stopwatch.SetStartTime();
          break;
        case 2:
          stopwatch.SetStopTime();
          var difference = stopwatch.Difference();
          System.Console.WriteLine(difference);
          break;
        default:
          throw new InvalidOperationException("wrong option");
          break;
      }
    }

    // System.Console.Write("Press Enter to start");
    // Console.Read();
    // now.SetStartTime();
    // System.Console.WriteLine($"Start time is: {now.Start.ToString("HH:mm:ss")}");
    // System.Console.Write("Press Enter to stop");
    // Console.Read();
    // now.SetStopTime();
    // System.Console.WriteLine($"Stop time is: {now.Stop.ToString("HH:mm:ss")}");
    // // var difference = now.Stop - now.Start;
    // var difference = now.Difference(now.Start, now.Stop);
    // System.Console.WriteLine(difference.Seconds);

    // while (difference != null)
    // {
    //   System.Console.Write("Press Enter to start");
    //   Console.Read();
    //   now.SetStartTime();
    //   System.Console.WriteLine($"Start time is: {now.Start.ToString("HH:mm:ss")}");
    //   System.Console.Write("Press Enter to stop");
    //   Console.Read();
    //   now.SetStopTime();
    //   System.Console.WriteLine($"End time is: {now.Stop.ToString("HH:mm:ss")}");
    //   // var difference = now.Stop - now.Start;
    //   var difference = now.Difference(now.Start, now.Stop);
    //   System.Console.WriteLine(difference.Seconds);
    // }


  }
}
