using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
  public class WorkflowEngine
  {
    private readonly IList<IActivity> _activity;
    public WorkflowEngine()
    {
      _activity = new List<IActivity>();
    }
    public void Run()
    {
      //should execute activities here - these individual activities implement an interface with Execute()
      foreach (var individualActivity in _activity)
      {
        individualActivity.Execute();
      }
    }
    public void RegisterActivity(IActivity activity)
    {
      _activity.Add(activity);
    }
  }
}