

/// this program write text inside of text file according to how many lines user wants 
/// also a ignore condtion that that ignore text won't be written insde of the text
///


namespace program
{
    class WorkingWithFiles
    {
        public static void Main(string[] args)
        {

            var OurFile = @"C:\Games\newfile.txt";

            Console.Write("Enter Your Ignore Text : ");
            var IgnoreTxt = Console.ReadLine();

            Console.WriteLine("Enter how many lines you want : ");
            var Number = Convert.ToInt32(Console.ReadLine());

            string[] WordSapce = new string[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Enter Words Baby : ");
                WordSapce[i] = Console.ReadLine();
                if (!WordSapce[i].Contains(IgnoreTxt))
                {
                    File.WriteAllLines(OurFile, WordSapce);
                }
            }

        }
    }
}