

/// 1- Write a program and ask the user to enter a number. 
/// The number should be between 1 to 10. If the user enters 
/// a valid number, display "Valid" on the console. Otherwise, 
/// display "Invalid". (This logic is used a lot in applications 
/// where values entered into input boxes need to be validated.)


namespace If_and_Swtich
{
    class Exercises
    {
        static void Main(string[] args)

        {
            int number;
            Console.WriteLine("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {

                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}


