
/// برنامه ای که برای هر عدد روز هفته رو نشان دهد مثلا 0 شنبه 1 یک شنبه
///
/// this lil code show name of week via number that user call in program




namespace practise;

class program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Number : ");
        int Daynum = Convert.ToInt32(Console.ReadLine());
        switch (Daynum)
        {
            case 0:
                Console.WriteLine("shanbeh");
                break;

            case 1:
                Console.WriteLine("1 Shanbeh");
                break;

            case 2:
                Console.WriteLine("2 shanbeh");
                break;

            case 3:
                Console.WriteLine("3 shanbeh");
                break;

            case 4:
                Console.WriteLine("4 Shanbeh");
                break;

            case 5:
                Console.WriteLine("5 shanbeh");
                break;

            case 6:
                Console.WriteLine("jomeh");
                break;

            default:
                Console.WriteLine("Not Found");
                break;

        }




    }

}