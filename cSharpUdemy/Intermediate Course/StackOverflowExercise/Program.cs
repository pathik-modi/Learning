namespace StackOverflowExercise;
public class Post
{
  public string Title { get; private set; }
  public string Description { get; private set; }
  public DateTime CreationDate { get; private set; }
  public int Vote { get; private set; }
  public bool PostExist { get; private set; }

  public void CreatePost()
  {
    if (PostExist)
      throw new InvalidOperationException("Post Already exist");
    PostExist = true;
    CreationDate = DateTime.Today;
    System.Console.WriteLine("Title");
    Title = System.Console.ReadLine();
    Console.Clear();
    System.Console.WriteLine("Description");
    Description = System.Console.ReadLine();
    Console.Clear();
  }

  public int UpVote()
  {
    Vote++;
    System.Console.WriteLine($"Vote Count: {Vote}");
    return Vote;
  }
  public int DownVote()
  {
    Vote--;
    System.Console.WriteLine($"Vote Count: {Vote}");
    return Vote;
  }

}
class Program
{
  static void Main(string[] args)
  {
    var post = new Post();
    post.CreatePost();
    System.Console.WriteLine($"Here's your post\nTitle: {post.Title}\nCreated On: {post.CreationDate}\nDescription: {post.Description}\nVotes: {post.Vote}");
    System.Console.WriteLine("Enter up or down to change Votes and end to exit");
    var voteInput = Console.ReadLine().Trim().ToLower();
    while (voteInput != "end")
    {
      switch (voteInput)
      {
        case "up":
          post.UpVote();
          voteInput = Console.ReadLine().Trim().ToLower();
          break;
        case "down":
          post.DownVote();
          voteInput = Console.ReadLine().Trim().ToLower();
          break;
        default:
          System.Console.WriteLine("Wrong option try again");
          voteInput = Console.ReadLine().Trim().ToLower();
          break;
      }
    }
  }
}
