

//3- Write a program and ask the user to enter the width
//and height of an image. Then tell if the image is landscape or portrait.



namespace If_and_Swtich
{
    class Exercises
    {

        static void Main(string[] args)

        { 
            
            int Width;
            int Height;

            Console.WriteLine("Enter Width");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height");
            Height = Convert.ToInt32(Console.ReadLine());   


            if (Width > Height)
            {
                Console.WriteLine("It's Landscape");
            }
            else
            {
                Console.WriteLine("It's Potrate");
            }



        }

    }
}