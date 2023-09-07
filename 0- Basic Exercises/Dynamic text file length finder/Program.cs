





namespace program
{
    class WorkingWithFiles
    {
        public static void Main(string[] args)
        {

            var TextFile = new StreamReader(@"C:\Games\newfile.txt");
            int count = -1;
            var listline = new List<string>();

            while (true)
            {
                if (TextFile != null)
                {
                    listline.Add(TextFile.ReadLine());
                    count++;
                    if (listline.Contains(null))
                    {
                        listline.Remove(null);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            string[] TextLine = new string[count];
            listline.CopyTo(TextLine);

            for (int i = 0; i <= count - 1; i++)
            {
                Console.WriteLine("Line " + (i + 1) + " == " + TextLine[i].Length);
            }



        }



    }
}