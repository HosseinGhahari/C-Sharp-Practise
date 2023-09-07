

////////////////////// حالا میخواهیم ورودی ها را خودمون مشخص کنیم در واقع 5 ورودی بگیرد و زوج ها را مشخص کند
///
/// this practise code show even numbers with 5 input numbers that user give 


namespace practise;

class program
{

    public static void Main(string[] args)
    {


        int[] Numbers = new int[5];

        for (int i = 0; i < Numbers.Length; i++)
        {
            Console.WriteLine("Enter Your Number : ");
            Numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("numbers are : ");
        for (int i = 0; i < Numbers.Length; i++)
        {

            if (Numbers[i] % 2 == 0)
            {
                Console.Write(" " + Numbers[i]);

            }

        }


    }
}





