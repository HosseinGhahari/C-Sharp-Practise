

/// در این قطعه کد اعداد زوج و فرد درون ارایه مشخص میشود
//
/// this code show odd and even numbers inside of a array 


namespace Test;

public class programe
{
    public static void Main(string[] args)
    {

        var array = new int[100];
        int i, Odd = 0, Even = 0, Size;

        Console.WriteLine("Enter Size of array : ");
        Size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the numbers : ");
        for (i = 0; i < Size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < Size; i++)
        {
            if (array[i] % 2 == 0)
            {
                Even++;
            }
            else
            {
                Odd++;
            }
        }

        Console.WriteLine("Count of even : " + Even);
        Console.WriteLine("Count of even : " + Odd);


    }
}

