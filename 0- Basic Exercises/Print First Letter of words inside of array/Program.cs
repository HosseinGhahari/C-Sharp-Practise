

/// این برنامه حرف اول کلمه ای را از کاربر میگیرد اگر در آرایه قرار داشت نشان می دهد.
//
/// this code show first letter of word that use give and if the letter exist in array , print it



public class program
{



    public static void Main(string[] args)
    {
        var arr = new string[5] { "Hello", "World", "Program", "Software", "Problem", };
        Console.Write("Enter First letter You want : ");
        string First = Console.ReadLine();
        var MainResult = FirstLetter(arr, First);
        Console.Write("the result is : " + MainResult);
    }


    public static string FirstLetter(string[] arr, string Frist)
    {

        string result = "";

        foreach (var item in arr)
        {
            if (item.Substring(0, 1).ToLower() == Frist)
            {
                return result = item;
            }
        }

        return result;
    }




}



