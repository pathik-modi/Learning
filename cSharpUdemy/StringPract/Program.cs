namespace StringPract;

class Program
{
  static void Main(string[] args)
  {
    var fullName = "Pathik Modi ";
    System.Console.WriteLine($"Trim: '{fullName.Trim()}'");
    System.Console.WriteLine($"Upper Case: '{fullName.Trim().ToUpper()}'");

    var index = fullName.IndexOf(' ');
    var firstName = fullName.Substring(0, index);
    var lastName = fullName.Substring(index + 1);
    System.Console.WriteLine($"First Name: {firstName}");
    System.Console.WriteLine($"Last Name: {lastName}");

    var names = fullName.Split(' ');
    System.Console.WriteLine($"First Name: {names[0]}");
    System.Console.WriteLine($"First Name: {names[1]}");

    System.Console.WriteLine(fullName.Replace("Pathik", "Patrick"));

    var sentence = "This sentence is going to be really really really really long";
    var summary = SummerizeText(sentence);
    System.Console.WriteLine(summary);

  }

  static string SummerizeText(string text, int maxLength = 25)
  {

    if (text.Length < maxLength)
    {
      return text;
    }
    else
    {
      var words = text.Split(' ');
      var totalCharacters = 0;
      var summaryWords = new List<string>();

      foreach (var word in words)
      {
        summaryWords.Add(word);
        totalCharacters += word.Length + 1;
        if (totalCharacters > maxLength)
        {
          break;
        }
      }
      return String.Join(" ", summaryWords) + "...";

    }
  }
}
