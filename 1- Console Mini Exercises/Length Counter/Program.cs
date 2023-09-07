
///// طول کارکتر رو بدون فضای خالی می شمارد



namespace practise;

class program
{
    public static void Main(string[] args)
    {
        string space = " ";
        string n;
        Console.WriteLine("Enter Your text : ");
        n = Console.ReadLine();
        n = n.Replace(" ", ""); // جایگذاری انجام میدهد 
        Console.WriteLine("Text Count is : " + n.Length);

    }
}


