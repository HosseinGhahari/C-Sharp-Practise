using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http.Headers;
using System.Security.AccessControl;


namespace program
{
    class WorkingWithFiles
    {
        public static void Main(string[] args)
        {
            var TextFile = new StreamReader(@"C:\Games\newfile.txt");
            TexTSeeker(TextFile);
        }


        public static void TexTSeeker(StreamReader file)
        {
            int count = -1;
            var listline = new List<string>();

            while (true)
            {
                if (file != null)
                {
                    listline.Add(file.ReadLine());
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