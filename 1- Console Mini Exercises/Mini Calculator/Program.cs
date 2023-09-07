

namespace practise;

class program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("enter num 1 :");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Your Opreator :");
        char OpreatorMe = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter num2 :");
        double Number2 = Convert.ToDouble(Console.ReadLine());


        if (OpreatorMe == '+')
        {
            Console.WriteLine("Result is " + (number1 + Number2));
        }

        else if (OpreatorMe == '-')
        {
            Console.WriteLine("Result is " + (number1 - Number2));
        }

        else if (OpreatorMe == '*')
        {
            Console.WriteLine("Result is " + (number1 * Number2));
        }

        else if (OpreatorMe == '/')
        {
            Console.WriteLine("Result is " + (number1 / Number2));

        }

        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Congrats bro you just wrote a mini calculater app");

    }
}




