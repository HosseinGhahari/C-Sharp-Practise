

// Write a program and ask the user to enter an English word. Count the number of vowels 
// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).


namespace Working_With_Text
{
    public class Exercises
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter English Word : ");
            var Words = Console.ReadLine().ToLower();
            var count = 0;
            var vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };

            foreach (var vowel in Words)
            {
                if (vowels.Contains(vowel))
                {
                    count++;
                }
            }

            Console.Write("number of vowels are : " + count);

        }

    }

}