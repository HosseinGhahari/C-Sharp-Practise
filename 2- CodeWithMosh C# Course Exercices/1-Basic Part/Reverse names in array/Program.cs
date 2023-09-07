

///2- Write a program and ask the user to enter their name.
///Use an array to reverse the name and then store the result 
///in a new string. Display the reversed name on the console.




namespace Arrays_and_Lists
{
    class Exercises
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter Names : ");
            var Name = Console.ReadLine();

            var Array = new char[Name.Length];
            for (var i = Name.Length; i > 0; i--)
            {
                Array[Name.Length - i] = Name[i - 1];
            }
            var Reverse = new string(Array);
            Console.WriteLine("Reversed name: " + Reverse); 

        }
    }
}