
///////////////////// دریافت سال تولد و تبدیل به سن کاربر
///
/// this lil practise code take the year of birth and convert it to age of user




namespace practise;

class program
{

    public static void Main(string[] args)
    {


        Console.WriteLine("Enter Your Year Birth : ");
        int Now = 1402;
        int Year = Convert.ToInt32(Console.ReadLine());
        int Result = Now - Year;
        Console.WriteLine("Your Age is : " + Result);


    }

}