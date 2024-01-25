namespace FileFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var path = $"SSD/Users/pathikmodi/devAcademy/Learning";
            // File.Copy($"SSD/Users/pathikmodi/devAcademy/Learning/README.md", $"SSD/Users/pathikmodi/devAcademy/Learning/README.md", true);
            // File.Delete(path);
            // if (File.Exists(path))
            // {
            //     //
            // }
            // var content = File.ReadAllText(path);
            //
            // // fileInfo
            // var fileInfo = new FileInfo(path);
            // fileInfo.CopyTo("...");
            // fileInfo.Delete();
            // if (fileInfo.Exists)
            // {
            //     //
            // }

            var files = Directory.GetFiles($"/Users/pathikmodi/devAcademy/Learning", "*.md",
                SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories($"/Users/pathikmodi/devAcademy/Learning", "*.md",
                SearchOption.AllDirectories);
            foreach (var items in directories)
            {
                Console.WriteLine(items);    
            }
            
            // Exercise 1 - read text file and return numbers
            var textFile = File.ReadAllText($"/Users/pathikmodi/devAcademy/Learning/cSharpUdemy/FileFundamentals/test.txt");
            string[] textArr = textFile.Trim().Split(" ").ToArray();
            Console.WriteLine($"Number of Words: {textArr.Count()}");
            
            // Exercise 2 - read text file and display longest word
            var longestWord = textArr[0];
            for (int i = 1; i < textArr.Length ; i++)
            {
                if (textArr[i].Length > textArr[i - 1].Length)
                {
                    longestWord = textArr[i];
                }
            }

            Console.WriteLine($"Longest Word: {longestWord}");
        }
    }
}