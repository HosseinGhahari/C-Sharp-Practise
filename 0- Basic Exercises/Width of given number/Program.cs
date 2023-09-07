

/// این قطعه کد یه مربع با اعداد داده شده به طول عددی که میدهیم رسم میکند
//
/// make a Square with given number and given width 



namespace Test;

public class program
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Enter the number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Width : ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");


        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                Console.Write(number);

            }
            Console.Write("\n");
        }

    }


}