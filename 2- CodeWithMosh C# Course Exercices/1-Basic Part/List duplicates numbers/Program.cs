

// 4- Write a program and ask the user to continuously
// enter a number or type "Quit" to exit.
// The list of numbers may include duplicates.
// Display the unique numbers that the user has entered.



namespace Arrays_and_Lists
{
    class Exercises
    {

        static void Main(string[] args)
        {


            var ListNumbers = new List<int>();
            var NewInput = 0;
            while (true)
            {

                Console.WriteLine("Enter Number (or 'quit' for exit) ");
                var InputNumber = Console.ReadLine();
                if (InputNumber.ToLower() == "quit")
                {
                    break;
                }

                NewInput = Convert.ToInt32(InputNumber);
                ListNumbers.Add(NewInput);

            }

            var uniqe = new List<int>();
            foreach (int newinput in ListNumbers)
            {
                if (!uniqe.Contains(newinput))
                {
                    uniqe.Add(newinput);
                }
            }

            foreach (int newinput in uniqe)
            {
                Console.Write("\n");
                Console.Write(newinput);
            }


        }
    }
}