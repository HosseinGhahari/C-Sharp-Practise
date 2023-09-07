

/////////////////////////// برنامه ای که حقوق کاربر را بگیرد و یک بار بگوید با 7 درصد بیمه کسر شده و  با 10 درصد مالیات چقدر باقی میماند از حقوق
///////// من در اینجا درصد ها رو به صورت دستی وارد کردم
///


namespace practise;

class program
{

    public static void Main(string[] args)
    {
        try
        {

            double Salary, Insurance, Tax, ResultBimeh, ResultTax, Money, InsuranceFirst, TaxFirst;

            Console.WriteLine("Enter Your Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Insurance Percentage : ");
            InsuranceFirst = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Tax Percentage : ");
            TaxFirst = Convert.ToDouble(Console.ReadLine());

            Insurance = InsuranceFirst / 100;
            Tax = TaxFirst / 100;

            ResultBimeh = Salary - (Salary * Insurance);
            ResultTax = Salary - (Salary * Tax);
            Money = (ResultBimeh + ResultTax) - Salary;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Insurance with 7% is : " + ResultBimeh + " Rial" + " ---------- " + " Tax wiith 10% is  : " + ResultTax + " Rial" + " ----------- " + " Save Money is : " + Money + " Rial");

        }

        catch
        {
            Console.WriteLine("Please Only Enter Number ");
        }

    }
}

