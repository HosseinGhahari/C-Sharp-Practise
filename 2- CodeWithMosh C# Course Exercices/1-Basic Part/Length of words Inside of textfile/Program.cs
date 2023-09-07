


// Write a program that reads a text file and displays the number of words.


namespace program
{
    class WorkingWithFiles
    {
        public static void Main(string[] args)
        {
            var ReadText = new StreamReader(@"C:\Games\mytext.txt");
            string holder = "";
            holder = ReadText.ReadToEnd();
            Console.WriteLine(holder.Length);
        }
    }
}