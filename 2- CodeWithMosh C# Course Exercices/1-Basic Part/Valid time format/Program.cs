

// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 





namespace Working_With_Text
{
    public class Exercises
    {
        static void Main(string[] args)
        {


            Console.Write("Enter Time with (24 hour time) : ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Invalid");
                return;
            }

            var Time = input.Split(':');

            if (Time.Length != 2)
            {
                Console.Write("Invalid");
                return;

            }
            try
            {
                var hour = Convert.ToInt32(Time[0]);
                var minute = Convert.ToInt32(Time[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                {
                    Console.WriteLine("its ok");
                }
                else
                {
                    Console.Write("Invalid");

                }
            }
            catch (Exception)
            {
                Console.Write("Invalid");
            }



        }
    }
}