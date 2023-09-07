

// Write a program that reads a text file and displays the longest word in the file.




namespace program
{
    class WorkingWithFiles
    {
        public static void Main(string[] args)
        {

           var TextFile = new StreamReader(@"C:\test.txt");
           string Line;
           int count = 0;
           string word = "";
           Line = TextFile.ReadLine();

           foreach (var text in Line.Split(" "))
           {
              if (text.Length > count)
               {
                   word = text;
                   count = text.Length;
               }
           }

           Console.WriteLine(word);


        }
    }
}