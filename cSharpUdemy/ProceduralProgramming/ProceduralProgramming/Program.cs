namespace ProceduralProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your name below:");
            string user = Console.ReadLine();
            var reversed = ReverseName(user);
            System.Console.WriteLine($"Reversed name is: {reversed}");
        }

        public static string ReverseName(string user)
        {
            char[] userArray = new char[user.Length];
            for (var i = 0; i < user.Length; i++) {
                userArray[i] = user[i];
            }
            Array.Reverse(userArray); // reversed the newly created array
            return new string(userArray); // converting to string
        }
    }
}
