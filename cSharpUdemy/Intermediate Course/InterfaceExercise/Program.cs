namespace InterfaceExercise;

class Program
{
  static void Main(string[] args)
  {
    var workflow = new WorkflowEngine();
    workflow.RegisterActivity(new UploadVideo());
    workflow.RegisterActivity(new Encoding());
    workflow.Run();
  }
}
