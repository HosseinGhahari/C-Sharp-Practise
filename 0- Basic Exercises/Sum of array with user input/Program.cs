

/// برنامه ای که به مقدار دلخواهی که میخواهیم در ارایه مقدار دهی میشود و نتیجه ان را جمع میکند و چاپ میشود
//
/// Print sum of the input numbers inside a array 




namespace Test;

public class programe
{

    public static void Main(string[] args)
    {

        var array = new int[100];
        int i, Size, sum = 0;

        Console.WriteLine("Enter Size of Array : ");
        Size = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter The Numbers : ");

        for (i = 0; i < Size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < Size; i++)
        {
            sum = array[i] + sum;
        }

        Console.WriteLine("\n");
        Console.WriteLine("Sum is : " + sum);


    }



}