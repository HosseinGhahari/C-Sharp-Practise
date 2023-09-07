

/// در این قطعه کد تعداد مقادیری که میخواهیم در ارایه مشخص میکنیم و عدد به ان میدهیم و نمایش داده میشود
//
/// in this code user set the amount of size that user can input numbers in a array and print them

namespace Test;

public class programe
{



    public static void Main(string[] args)
    {


        var array = new int[100];
        int i;
        Console.WriteLine("Enter Size of Array : ");
        var Size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Of the Array Numbers : ");

        for (i = 0; i < Size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("List of arrays are : ");
        for (i = 0; i < Size; i++)
        {
            if (array[i] < 0)
            {
                Console.WriteLine(array[i]);
            }

            Console.Write(" " +array[i] + " ");
        }




    }
}