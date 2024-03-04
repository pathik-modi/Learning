using System.Collections.Generic;

namespace InheritanceExercise;

public class Stack
{
  private Stack<object> _testStack = new Stack<object>();

  public void Push(object obj)
  {
    if (obj != null)
    {
      _testStack.Push(obj);
    }
    else
    {
      throw new InvalidOperationException("Cannot add empty obj");
    }
  }
  public object Pop()
  {
    if (_testStack.Count > 0)
    {
      return _testStack.Pop();
    }
    else
    {
      throw new InvalidOperationException("Empty stack");
    }
  }
  public void Clear()
  {
    _testStack.Clear();
  }
}

class Program
{
  static void Main(string[] args)
  {
    var stack = new Stack();
    stack.Push(1);
    stack.Push(2);
    stack.Push("three");

    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
  }
}
