



/*/// 1- When you post a message on Facebook, depending on the 
/// number of people who like your post, Facebook displays different information.

//// Write a program and continuously ask the user to enter different names, until
/// the user presses Enter (without supplying a name). Depending on the number of
/// names provided, display a message based on the above pattern.*/



namespace Arrays_and_Lists
{
    class Exercises
    {

        static void Main(string[] args)
        {

             String Names;
             var MyNames = new List<string>();
             while (true)
             {
                 Console.WriteLine("Enter Name :");
                 Names = Console.ReadLine();

                 if (Names == "")
                 {
                     break;
                 }
                 else
                 {
                     MyNames.Add(Names);
                 }
             }

             Console.Write(MyNames[0] + " and " + MyNames[1]);
             int Count = MyNames.Count - 2;
             Console.WriteLine(" and " + Count + " others People Liked Your Post ");

        }
    }
}
