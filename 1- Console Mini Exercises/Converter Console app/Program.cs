
namespace practise;

class program
{

    public static void Main(string[] args)
    {

        Double Result, ResultSecond, M, K, Ask;
        int KtoM = 1;
        int MtoK = 2;

        Console.WriteLine("Whhat covert do you need ? " + "select your option" + "\n" + "(1) Kilometer to Meter " + "---" + " (2) Meter to Kilometer");
        Ask = Convert.ToInt32(Console.ReadLine());

        if (Ask == KtoM)
        {
            Console.WriteLine("Enter your number to Convert : ");
            M = Convert.ToInt32(Console.ReadLine());
            Result = M * 1000;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Convert Result is : " + Result + " Meter");
            Console.WriteLine("\n");
        }
        else if (Ask == MtoK)
        {
            Console.WriteLine("Enter your number to Convert : ");
            K = Convert.ToInt32(Console.ReadLine());
            ResultSecond = K / 1000;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Convert Result is : " + ResultSecond + " Kilo Meter");
            Console.WriteLine("\n");

        }

    }
}




