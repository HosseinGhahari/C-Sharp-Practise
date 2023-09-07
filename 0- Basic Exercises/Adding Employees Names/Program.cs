

/// برنامه ای که تعداد کارمند ها رو بگیره و به تعداد کارمند ها اسم هاشون رو مشخص کنه با کمک ارایه
///
/// This Practise code Add Employees Names According To User Count Input and show them



namespace practise;

class program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Number of People : ");
        int Numbers = Convert.ToInt32(Console.ReadLine());

        string[] Names = new string[Numbers];
        for (int i = 0; i < Numbers; i++)
        {
            Console.WriteLine("Enter Names :" + (i + 1));
            Names[i] = Console.ReadLine();
        }

        Console.Write("Names are : ");
        foreach (string name in Names)
        {
            Console.Write(name + " ");
        }



    }

}


