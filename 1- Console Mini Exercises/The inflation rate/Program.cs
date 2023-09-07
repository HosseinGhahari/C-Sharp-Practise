

/////////////////////////////////////////////// برنامه ای که قیمت کالا سال قبل و جاری را خوانده و نرخ تورم و قیمت سال بعد آن را محاصبه کند
///

namespace practise;

class program
{

    public static void Main(string[] args)
    {

        double LastYear, CurrentYear, Nextyear, inflation;
        Console.WriteLine("Enter Price For Last year : ");
        LastYear = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Price for Current Year: ");
        CurrentYear = Convert.ToDouble(Console.ReadLine());

        inflation = (CurrentYear - LastYear) / LastYear;
        Nextyear = LastYear + CurrentYear * inflation;
        Console.WriteLine("Inflation is : " + inflation + " %" + " ----------" + " Next Year Price is : " + Nextyear);

    }
}





