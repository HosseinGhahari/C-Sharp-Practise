

// 1- Write a program and ask the user to enter a few numbers separated by a hyphen.
// Work out if the numbers are consecutive. For example, if the input is
// "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise,
// display "Not Consecutive".



namespace Working_With_Text
{
    public class Exercises
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Numbers with Hyphen(-) : ");
            var input = Console.ReadLine();

            var list = new List<int>();
            foreach (var i in input.Split('-'))
            {
                list.Add(Convert.ToInt32(i));
            }
            list.Sort();

            bool Final = true;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] != list[i - 1] + 1)
                {

                    Final = false;
                    break;

                }
            }

            if (Final)
            {
                Console.WriteLine("Its Consecutive Bro");
            }
            else
            {
                Console.WriteLine("It's Not Consecutive Mate");
            }





        }
    }
}